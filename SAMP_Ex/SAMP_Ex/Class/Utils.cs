using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.Xml.Linq;

using System.Diagnostics;

namespace SAMP_Ex
{
    class Utils
    {
        /// <summary>
        /// Check if an IP address string is valid
        /// </summary>
        /// <param name="ipaddress"></param>
        /// <returns>True if IP is valid, false if not</returns>
        public static bool IsValidIpAddress(string ipaddress)
        {
            IPAddress address;
            try
            {
                address = Dns.GetHostAddresses(ipaddress).First();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Chekc if a port string is valid
        /// </summary>
        /// <param name="port"></param>
        /// <returns>True if port if valid, false if not</returns>
        public static bool IsValidPort(string port)
        {
            int intPort;
            if (Int32.TryParse(port, out intPort))
            {
                if (intPort > 65535 || intPort < 0)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Parse an IP address from an ip & port combined string address eg. "127.0.0.1:7777" or "mydomain.com:7777"
        /// </summary>
        /// <param name="ipport"></param>
        /// <returns>IP from given string</returns>
        public static string ParseIPFromIPPort(string ipport)
        {
            try
            {
                return ipport.Split(':')[0];
            }
            catch(IndexOutOfRangeException ex)
            {
                return "";
            }
        }

        /// <summary>
        /// Parse a port from an ip & port combined string address eg. "127.0.0.1:7777" or "mydomain.com:7777"
        /// </summary>
        /// <param name="ipport"></param>
        /// <returns>Port from given string</returns>
        public static string ParsePortFromIPPort(string ipport)
        {
            try
            {
                return ipport.Split(':')[1];
            }
            catch (IndexOutOfRangeException ex)
            {
                return "";
            }
        }

        public static bool CreateDefaultConfigFile(string path)
        {
            try
            {
                XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Launcher configuration file"),
                new XElement("configuration",
                    new XElement("user",
                        new XElement("defaultnick", ""),
                        new XElement("gtapath", GTAUtils.GetGTADir()))),
                new XElement("sampdll"));

                doc.Save(path);

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }           
        }

        public static bool CreateDefaultFavList(string path)
        {
            try
            {
                XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Favorites list"),
                new XElement("favorites",
                    new XElement("server",
                        new XElement("ip", "127.0.0.1:7777"),
                        new XElement("nickname", ""),
                        new XElement("password", ""))));

                doc.Save(path);

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
