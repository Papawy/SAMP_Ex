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
	public class ConfigFile
	{
        public static bool Load(string file)
        {
            try
            {
                _ConfigFile = XDocument.Load(file);
                _filepath = file;
                return true;
            }
            catch(Exception e)
            {
                Debug.Write(e.Message);
                return false;
            }
        }

        public static void Save()
        {
            _ConfigFile.Save(_filepath);
        }

        public static void SetConfig(string subPart, string configName, string value, bool createIfDontExist = false)
        {
            var userConf = _ConfigFile.Descendants(subPart).Select(b => b.Element(configName)).FirstOrDefault();

            if (userConf != null)
                userConf.Value = value;
            else if (createIfDontExist)
            {
                _ConfigFile.Element("configuration").Element(subPart).Add(new XElement(configName, value));
            }
        }

        public static string GetConfig(string subPart, string configName)
        {
            var userConf = _ConfigFile.Descendants(subPart).Select(b => b.Element(configName)).FirstOrDefault();

            if (userConf != null)
                return userConf.Value;
            else
                return "";
        }

        // this is just a shortcut
		public static void SetUserConfig(string configName, string value, bool createIfDontExist = false)
		{
            SetConfig("user", configName, value, createIfDontExist);
        }

        // this is just a shortcut
		public static string GetUserConfig(string configName)
		{
            return GetConfig("user", configName);
		}

		public static string GetFile()
		{
			return _filepath;
		}

		#region Attributes       
		//private static Dictionary<string, string> m_userConfigs = new Dictionary<string, string>();
		//private static string m_version;
		private static string _filepath;
        private static XDocument _ConfigFile;
		#endregion
	}
}
