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

        /// <summary>
        /// Save current configuration values in the file
        /// </summary>
        public static void Save()
        {
            _ConfigFile.Save(_filepath);
        }

        /// <summary>
        /// Set a configuration value
        /// </summary>
        /// <param name="subPart">Subpart</param>
        /// <param name="configName">Configuration name</param>
        /// <param name="value">Configuration value</param>
        /// <param name="createIfDontExist">Create given configuration if it doesn't exist</param>
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

        /// <summary>
        /// Get a configuration value
        /// </summary>
        /// <param name="subPart"></param>
        /// <param name="configName"></param>
        /// <returns>Configuration value as string</returns>
        public static string GetConfig(string subPart, string configName)
        {
            var userConf = _ConfigFile.Descendants(subPart).Select(b => b.Element(configName)).FirstOrDefault();

            if (userConf != null)
                return userConf.Value;
            else
                return String.Empty;
        }

        /// <summary>
        /// This is just a shorcut to SetConfig("user", ...)
        /// </summary>
        /// <param name="configName"></param>
        /// <param name="value"></param>
        /// <param name="createIfDontExist"></param>
		public static void SetUserConfig(string configName, string value, bool createIfDontExist = false)
		{
            SetConfig("user", configName, value, createIfDontExist);
        }

        /// <summary>
        /// This is just a shortcut to GetConfig("user", configName)
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
		public static string GetUserConfig(string configName)
		{
            return GetConfig("user", configName);
		}

        /// <summary>
        /// Check if a SAMP Dll is present for a specified version
        /// </summary>
        /// <param name="sampvrs">samp version (ex : "0.3.7-R2")</param>
        /// <returns>True if found, false if not</returns>
        public static bool IsSAMPDllVersionAvalaible(string sampvrs)
        {
            if (GetConfig("sampdll", sampvrs) == String.Empty) return false;
            else return true;
        }

        /// <summary>
        /// Return the SAMP Dll name for the specified version
        /// </summary>
        /// <param name="sampvrs">samp version (ex : "0.3.7-R2")</param>
        /// <returns>SAMP Dll name</returns>
        public static string GetSAMPDllNameForVersion(string sampvrs)
        {
            return GetConfig("sampdll", sampvrs);
        }

        /// <summary>
        /// Get file path
        /// </summary>
        /// <returns>File path</returns>
		public static string GetFile()
		{
			return _filepath;
		}

		#region Attributes       
		private static string _filepath;
        private static XDocument _ConfigFile;
		#endregion
	}
}
