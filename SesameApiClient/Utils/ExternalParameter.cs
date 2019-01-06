using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesameApiClient.Utils
{
    public static class ExternalParameter
    {
        static ExternalParameter()
        {
            LoadConfig();
        }

        public static void LoadConfig()
        {
            DefaultSesameApiURL = GetString("DefaultSesameApiURL");
            DefaultSesameToken = GetString("DefaultSesameToken");
            ConnectionTimeoutSec = GetInt("ConnectionTimeoutSec", 10);
        }

        public static string DefaultSesameApiURL { get; private set; }
        public static string DefaultSesameToken { get; private set; }
        public static int ConnectionTimeoutSec { get; private set; }

        #region [-]Method
        private static string GetString(string key, string default_val = "")
        {
            string ret = GetRawData(key);
            return (ret != null ? ret : default_val);
        }

        private static bool GetBool(string key, bool default_val = false)
        {
            bool ret;
            if (!bool.TryParse(GetRawData(key), out ret))
                ret = default_val;

            return ret;
        }

        private static int GetInt(string key, int default_val = 0)
        {
            int ret;
            if (!int.TryParse(GetRawData(key), out ret))
                ret = default_val;

            return ret;
        }

        private static string GetRawData(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        private static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        #endregion
    }
}
