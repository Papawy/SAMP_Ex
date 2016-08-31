using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

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
            if (IPAddress.TryParse(ipaddress, out address))
            {
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        return true;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        return true;
                    default:
                        return false;
                }
            }
            else
                return false;
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
    }
}
