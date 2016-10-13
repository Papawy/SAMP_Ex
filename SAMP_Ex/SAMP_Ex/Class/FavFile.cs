using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

using System.Diagnostics;

namespace SAMP_Ex
{
    class FavFile
    {
        public static bool Load(string file)
        {
            try
            {
                _FavFile = XDocument.Load(file);
                _filepath = file;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static void Save()
        {
            _FavFile.Save(_filepath);
        }

        public static bool AddServer(Server server, string nickname)
        {
            if (!server.IsValid)
                return false;

            var servip = _FavFile.Root.Descendants("server").Where(x => x.Element("ip").Value == (server.Ip.ToString()+":"+server.Port));
           

            if (nickname == String.Empty)
                nickname = ConfigFile.GetUserConfig("defaultnick");

            if (servip == null)
            {
                _FavFile.Element("favorites").Add(                   
                    new XElement("server",
                            new XElement("ip", server.Ip.ToString() + ":" + server.Port), 
                            new XElement("nickname", nickname),
                            new XElement("password", server.Password)));
                return true;
            }
            return false;
        }

        public static bool DeleteServer(Server server)
        {
            if (!server.IsValid)
                return false;
              
            var serv = _FavFile.Root.Descendants("server").Where(x => x.Element("ip").Value == (server.Ip.ToString() + ":" + server.Port)).First();

            if(serv != null)
            {
                serv.Remove();
                return true;
            }
            return false;
        }

        public static List<Server> GetFavoritesList()
        {
            try
            {
                List<Server> tmpList = new List<Server>();
                foreach (XElement xel in _FavFile.Root.Descendants("server"))
                {
                    try
                    {
                        tmpList.Add(new Server(xel.Element("ip").Value, xel.Element("nickname").Value));
                    }
                    catch (Exception ex) { }
                      
                }
                return tmpList;
            }
            catch (Exception ex)
            {
                return new List<Server>();
            }
        }

        #region Attributes       
        private static string _filepath;
        private static XDocument _FavFile;
        #endregion
    }
}
