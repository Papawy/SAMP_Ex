using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SAMP_Ex
{
    class WebLists
    {
        public static bool Load(string internetListAddress, string hostedListAddress)
        {
            try
            {
                GenerateInternetList(internetListAddress);
                GenerateHostedList(hostedListAddress);
                // need to add verification
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool GenerateInternetList(string website)
        {
            if(InternetList == null)
            {
                InternetList = new BindingList<Server>();
                InternetList.RaiseListChangedEvents = true;
            }
            InternetList.Clear();

            WebClient client = new WebClient();
            string strList = client.DownloadString(new Uri(website));
            try
            {
                foreach(string servip in strList.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    try
                    {
                        Server tmpServ = new Server(servip);
                        if (tmpServ.IsValid) InternetList.Add(tmpServ);
                    }
                    catch (Exception ex) { continue; }        
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                return false;
            }

            return true;
        }

        public static bool GenerateHostedList(string website)
        {
            if (HostedList == null)
            {
                HostedList = new BindingList<Server>();
                HostedList.RaiseListChangedEvents = true;
            }
            HostedList.Clear();

            WebClient client = new WebClient();
            string strList = client.DownloadString(new Uri(website));
            try
            {
                foreach (string servip in strList.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    try
                    {
                        Server tmpServ = new Server(servip);
                        if (tmpServ.IsValid) HostedList.Add(tmpServ);
                    }
                    catch (Exception ex) { continue; }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                return false;
            }

            return true;
        }

        #region Attributes       
        public static BindingList<Server> InternetList;
        public static BindingList<Server> HostedList;
        #endregion
    }
}
