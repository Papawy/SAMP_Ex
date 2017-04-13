using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.ComponentModel;


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
                GenerateFavList();
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
            try
            {
                var servip = _FavFile.Root.Descendants("server").Where(x => x.Element("ip").Value == (server.Ip.ToString() + ":" + server.Port)).FirstOrDefault();


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
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeleteServer(Server server)
        {            
            try
            {
                var serv = _FavFile.Root.Descendants("server").Where(x => x.Element("ip").Value == (server.Ip.ToString() + ":" + server.Port)).First();
                if (serv != null)
                {
                    serv.Remove();
                    FavList.Remove(FavList.Where(x => (x.Ip == server.Ip) && (x.Port == server.Port)).FirstOrDefault());
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }           
        }

        public static bool GenerateFavList()
        {
            if (FavList == null)
            {
                FavList = new BindingList<Server>();
                FavList.RaiseListChangedEvents = true;
            }
                
            FavList.Clear();
            
            try
            {
                foreach (XElement xel in _FavFile.Root.Descendants("server"))
                {
                    try
                    {
                        FavList.Add(new Server(xel.Element("ip").Value, xel.Element("nickname").Value));
                    }
                    finally { }

                }
                return true;
            }
            finally
            { 
            }
        }

        #region Attributes       
        private static string _filepath;
        private static XDocument _FavFile;
        public static BindingList<Server> FavList;
        #endregion
    }
}
