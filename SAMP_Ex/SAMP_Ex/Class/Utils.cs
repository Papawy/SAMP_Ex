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
