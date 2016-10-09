using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;

using System.Diagnostics;

namespace SAMP_Ex
{
    class Server
    {
        #region Property
        private Dictionary<string, string> _rules;
        private Dictionary<string, int> _players;

        private int _port;

        private DateTime _timestamp;
        private Socket _querySocket;
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

        #endregion

        public Server(string address, string port)
        {
            IsValid = true;

            if (Utils.IsValidPort(port))
            {
                Port = port;
                Int32.TryParse(Port, out _port);
            }
            else
                IsValid = false;


            _querySocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _querySocket.SendTimeout = 3000;
            _querySocket.ReceiveTimeout = 3000;

            try
            {
                Ip = Dns.GetHostAddresses(address)[0];
            }
            catch
            {
                IsValid = false;
            }
        }

        public Server(string addressAndPort) : this(Utils.ParseIPFromIPPort(addressAndPort), Utils.ParsePortFromIPPort(addressAndPort))
        {
        }

        private bool SendOpcode(char opcode)
        {

            // from https://wiki.sa-mp.com/wiki/Query_Mechanism/Csharp
            try
            {
                EndPoint serverEndPoint = new IPEndPoint(Ip, _port);

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

                    if (!(_querySocket.SendTo(stream.ToArray(), serverEndPoint) > 0))
                        return false;
                    else
                        return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private bool Receive()
        {
            try
            {
                EndPoint serverEndPoint = new IPEndPoint(Ip, _port);

                //System.Threading.Thread.Sleep(1000);

                byte[] buffer = new byte[3402];
                _querySocket.ReceiveFrom(buffer, ref serverEndPoint);

                using (MemoryStream receiveStream = new MemoryStream(buffer))
                {
                    using (BinaryReader reader = new BinaryReader(receiveStream))
                    {
                        if (receiveStream.Length <= 10)
                            return false;

                        reader.ReadBytes(10);

                        switch(reader.ReadChar())
                        {
                            case 'i':
                                {
                                    HasPassword = Convert.ToBoolean((reader.ReadByte()));

                                    Players = reader.ReadInt16();
                                    MaxPlayers = reader.ReadInt16();

                                    int hostnamelen = reader.ReadInt32();
                                    Hostname = new string(reader.ReadChars(hostnamelen));

                                    int gamemodelen = reader.ReadInt32();
                                    Gamemode = new string(reader.ReadChars(gamemodelen));

                                    int mapnamelen = reader.ReadInt32();
                                    MapName = new string(reader.ReadChars(mapnamelen));

                                    int language = reader.ReadInt32();
                                    Language = new string(reader.ReadChars(language));
                                    Debug.WriteLine("langue : "+Language);
                                    return true;
                                }
                            case 'r':
                                {
                                    _rules.Clear();

                                    int rulecount = reader.ReadInt16();

                                    for(int i = 0; i<rulecount; i++)
                                    {
                                        int rulelen = reader.ReadByte();
                                        string ruleName = new string(reader.ReadChars(rulelen));

                                        int valuelen = reader.ReadByte();
                                        string ruleValue = new string(reader.ReadChars(valuelen));

                                        _rules.Add(ruleName, ruleValue);
                                    }

                                    return true;
                                }
                            case 'c':
                                {
                                    _players.Clear();

                                    int playercount = reader.ReadInt16();

                                    for (int i = 0; i < playercount; i++)
                                    {
                                        int namelen = reader.ReadByte();
                                        string nickname = new string(reader.ReadChars(namelen));

                                        int score = reader.ReadInt32();

                                        _players.Add(nickname, score);
                                    }

                                    return true;
                                }
                            case 'p': // Ping
                                {
                                    Ping = DateTime.Now.Subtract(_timestamp).Milliseconds;

                                    return true;
                                }
                            default:
                                {
                                    return false;
                                }
                        }
                    }
                }
            }
            catch
            {
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
                return false;          
            }

            if(Receive())
            {
                return true;
            }
            else
            {
                return false;
            }
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

            if (Receive())
            {
                return true;
            }
            else
            {
                return false;
            }
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

            if (Receive())
            {
                return true;
            }
            else
            {
                return false;
            }
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

            if (Receive())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get a specific rule value
        /// </summary>
        /// <param name="rule">rule name</param>
        /// <returns>rule value</returns>
        public string GetRule(string rule)
        {
            if (_rules.ContainsKey(rule))
                return _rules[rule];
            else
                return String.Empty;
        }

        /// <summary>
        /// Get rules list
        /// </summary>
        /// <returns>A dictionary with rules name/value inside</returns>
        public Dictionary<string, string> GetRulesList()
        {
            return _rules;
        }

        /// <summary>
        /// Get players list
        /// </summary>
        /// <returns>A dictionary with players name/score inside</returns>
        public Dictionary<string, int> GetPlayersList()
        {
            return _players;
        }
    }
}
