using Autofac;
using ConfigAndLog4netWin.Configuration;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ConfigAndLog4netWin
{
    static class Program
    {
        public static IContainer Container { get; set; }
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new LoggingModule());
            string configDataPath = ConfigurationManager.AppSettings["configData"];
            ConfigData configData = JsonConvert.DeserializeObject<Configuration.ConfigData>(File.ReadAllText(configDataPath));
            builder.RegisterInstance<ConfigData>(configData);
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).
                Where(type => type.IsSubclassOf(typeof(Form))).PropertiesAutowired();
            Container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<frmMain>());
        }
    }
}
