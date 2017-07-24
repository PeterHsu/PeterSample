using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigAndLog4net
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
        internal static readonly Configuration.ConfigData configData;
        internal static readonly string connectionString;
        static Program()
        {
            string configDataPath = ConfigurationManager.AppSettings["configData"];
            configData = JsonConvert.DeserializeObject<Configuration.ConfigData>(File.ReadAllText(configDataPath));
            connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        }
        static void Main(string[] args)
        {
            logger.Debug("Hello, Log4net");
            logger.Info(configData.field);
            logger.Info(connectionString);
        }
    }
}
