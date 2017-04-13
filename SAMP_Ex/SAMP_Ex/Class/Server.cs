using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;

using System.Diagnostics;
using System.Threading;

namespace SAMP_Ex
{
    class Server
    {
        #region Property
        private ConcurrentDictionary<string, string> _rules;
        private ConcurrentDictionary<string, int> _players;

        private int _port;

        private DateTime _timestamp;
		private IPEndPoint _endPoint;
        private Socket _querySocket;

		private ManualResetEvent _receptionComplete;

        private byte[] _buffer;
        #endregion

        #region Accessors
        [Browsable(false)]
        public IPAddress Ip { get; private set; }
        [Browsable(false)]
        public string Port { get; private set; }

        public string Hostname { get; private set; }
        [Browsable(false)]
        public bool HasPassword { get; private set; }
        [Browsable(false)]
        public string Password { get; private set; }
        [Browsable(false)]
        public int MaxPlayers { get; private set; }
        public int Players { get; private set; }
        public string MapName { get; private set; }
        public string Gamemode { get; private set; }
        public string Language { get; private set; }

        public int Ping { get; private set; }

        [Browsable(false)]
        public bool IsValid { get; private set; }

        [Browsable(false)]
        public string Nickname { get; set; }

        #endregion

        public Server(string address, string port, string nickname="")
        {
            _rules = new ConcurrentDictionary<string, string>();
            _players = new ConcurrentDictionary<string, int>();
            _buffer = new byte[3402];

            Nickname = nickname;
            Password = "";

            IsValid = true;

            if (Utils.IsValidPort(port))
            {
                Port = port;
                Int32.TryParse(Port, out _port);
            }
            else
            {
                IsValid = false;
            }

            _querySocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			_querySocket.SendTimeout = 1000;
            _querySocket.ReceiveTimeout = 500;
			_querySocket.Blocking = true;

			_receptionComplete = new ManualResetEvent(false);

			try
            {
                Ip = Dns.GetHostAddresses(address)[0];
				_endPoint = new IPEndPoint(Ip, _port);
			}
            catch
            {
				IsValid = false;
				throw new Exception("Invalid IP");
            }


        }

        public Server(string addressAndPort, string nickname="") : this(Utils.ParseIPFromIPPort(addressAndPort), Utils.ParsePortFromIPPort(addressAndPort), nickname)
        {
        }

        public void SetPassword(string password)
        {
            Password = password;
        }

        public string GetVersion()
        {
            return this.GetRule("version");
        }

        private bool SendOpcode(char opcode)
        {

            // from https://wiki.sa-mp.com/wiki/Query_Mechanism/Csharp
            try
            {
				_buffer = new byte[3402];

				using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write("SAMP".ToCharArray());

                        string[] splitIP = Ip.ToString().Split('.');

                        writer.Write(Convert.ToByte(Convert.ToInt32(splitIP[0])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(splitIP[1])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(splitIP[2])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(splitIP[3])));

                        writer.Write((ushort)_port);

                        writer.Write(opcode);

                        if (opcode == 'p')
                            writer.Write("6666".ToCharArray());

                        _timestamp = DateTime.Now;
                    }

                    if (!(_querySocket.SendTo(stream.ToArray(), _endPoint) > 0))
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }

		protected void ParseReceivedBytes(byte[] buffer)
		{
			try
			{
				using (MemoryStream receiveStream = new MemoryStream(buffer))
				{
					using (BinaryReader reader = new BinaryReader(receiveStream))
					{
						if (receiveStream.Length <= 10)
						{
							reader.Dispose();
							receiveStream.Dispose();
							return;
						}

						reader.ReadBytes(10);

						switch (reader.ReadChar())
						{
							case 'i':
								{
									HasPassword = Convert.ToBoolean((reader.ReadByte()));

									Players = reader.ReadInt16();
									MaxPlayers = reader.ReadInt16();

									int hostnamelen = reader.ReadInt32();
									Hostname = System.Text.Encoding.UTF7.GetString(reader.ReadBytes(hostnamelen));

									int gamemodelen = reader.ReadInt32();
									Gamemode = System.Text.Encoding.UTF7.GetString(reader.ReadBytes(gamemodelen));

									int mapnamelen = reader.ReadInt32();
									MapName = System.Text.Encoding.UTF7.GetString(reader.ReadBytes(mapnamelen));

									if (reader.BaseStream.Position != reader.BaseStream.Length)
									{
										if (this.GetVersion() == "0.3.7" || this.GetVersion() == "0.3.7-R2" || this.GetVersion() == "0.3.7-R1")
										{
											int language = reader.ReadInt32();
											Language = System.Text.Encoding.UTF7.GetString(reader.ReadBytes(language));
										}
									}
									break;
								}
							case 'r':
								{
									_rules.Clear();

									int rulecount = reader.ReadInt16();
									int rulelen = 0;
									int valuelen = 0;

									for (int i = 0; i < rulecount; i++)
									{
										rulelen = reader.ReadByte();
										string ruleName = System.Text.Encoding.UTF7.GetString(reader.ReadBytes(rulelen));

										valuelen = reader.ReadByte();
										string ruleValue = System.Text.Encoding.UTF7.GetString(reader.ReadBytes(valuelen));


										if (!_rules.ContainsKey(ruleName))
											_rules.AddOrUpdate(ruleName, ruleValue, (key, val) => val);
										else
											_rules[ruleName] = ruleValue;
									}
									break;
								}
							case 'c':
								{
									_players.Clear();

									int playercount = reader.ReadInt16();
									if (playercount == 0)
									{
										break;
									}

									for (int i = 0; i < playercount; i++)
									{
										try
										{
											int namelen = 0;
											int score = 0;
											if (reader.BaseStream.Position != reader.BaseStream.Length)
											{
												namelen = reader.ReadByte();
											}
											else
											{
												break;
											}

											string nickname = System.Text.Encoding.UTF7.GetString(reader.ReadBytes(namelen));

											if (reader.BaseStream.Position + 4 != reader.BaseStream.Length)
											{
												try
												{
													//Debug.WriteLine(reader.BaseStream.Position + " : " + reader.BaseStream.Length);
													//score = reader.ReadInt32();
												}
												catch (EndOfStreamException ex) { Debug.WriteLine(ex.Data); score = 0; }

											}
											else
											{
												break;
											}

											if (!String.IsNullOrEmpty(nickname))
											{
												if (!_players.ContainsKey(nickname))
													_players.AddOrUpdate(nickname, score, (key, val) => val);
												else
													_players[nickname] = score;
											}
										}
										catch (Exception ex)
										{
											Debug.WriteLine(ex.ToString());
										}

									}

									break;
								}
							case 'p': // Ping
								{
									Ping = DateTime.Now.Subtract(_timestamp).Milliseconds;

									break;
								}
							default:
								{
									break;
								}
						}
						reader.Dispose();
						receiveStream.Dispose();
						_buffer = null;
						return;
					}
				}
			}
			catch(Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

        private bool Receive()
        {
            try
            {
				_buffer = new byte[3402];
				_querySocket.Receive(_buffer);
				if (_buffer != null)
				{
					try
					{
						ParseReceivedBytes(_buffer);
						return true;
					}
					catch (Exception ex)
					{
						Debug.WriteLine("Except : " + ex.ToString());
						return false;
					}
				}
				else return false;
					
				
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Except : " + ex.ToString());
				return false;
            }
            
        }

        /// <summary>
        /// Update all server informations
        /// </summary>
        /// <returns>True if all updates were success, false if not</returns>
        public bool TotalUpdate()
        {
            if ((UpdateInfos() && UpdatePing() && UpdatePlayerList() && UpdateRules()) == true)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Update basic server informations (Name, number of players, mapname, etc.)
        /// </summary>
        /// <returns>True if update was success, false if not</returns>
        public bool UpdateInfos()
        {
            if(!SendOpcode('i'))
            {
                if (String.IsNullOrWhiteSpace(this.Hostname))
                    this.Hostname = "SAMP 0.3 Server (No response)";

                return false;          
            }

			bool res = Receive();
			if (String.IsNullOrWhiteSpace(this.Hostname))
				this.Hostname = "SAMP 0.3 Server (No response)";
			return res;
        }

        /// <summary>
        /// Update rules of the server
        /// </summary>
        /// <returns>True if update was success, false if not</returns>
        public bool UpdateRules()
        {
            if (!SendOpcode('r'))
            {
                return false;
            }
			return Receive();
        }

        /// <summary>
        /// Update player list of the server
        /// </summary>
        /// <returns>True if update was success, false if not</returns>
        public bool UpdatePlayerList()
        {
            if (!SendOpcode('c'))
            {
                return false;
            }

			return Receive();
        }

        /// <summary>
        /// Update ping value
        /// </summary>
        /// <returns>True if update was success, false if not</returns>
        public bool UpdatePing()
        {
            if (!SendOpcode('p'))
            {
                return false;
            }

			return Receive();
        }

        /// <summary>
        /// Get a specific rule value
        /// </summary>
        /// <param name="rule">rule name</param>
        /// <returns>rule value</returns>
        public string GetRule(string rule)
        {
            string tmpvalue = "";
            if(_rules.TryGetValue(rule, out tmpvalue))
            {
                return tmpvalue;
            }
            /*if (_rules.ContainsKey(rule))
                return _rules[rule];*/
            else
                return String.Empty;
        }

        /// <summary>
        /// Get rules list
        /// </summary>
        /// <returns>A dictionary with rules name/value inside</returns>
        public ConcurrentDictionary<string, string> GetRulesList()
        {
            return _rules;
        }

        /// <summary>
        /// Get players list
        /// </summary>
        /// <returns>A dictionary with players name/score inside</returns>
        public ConcurrentDictionary<string, int> GetPlayersList()
        {
            return _players;
        }
    }
}
