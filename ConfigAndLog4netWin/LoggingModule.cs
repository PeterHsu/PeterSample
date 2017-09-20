using Autofac.Core;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConfigAndLog4netWin
{
    class LoggingModule : Autofac.Module
    {
        private static void InjectLoggerProperties(object instance)
        {
            var instanceType = instance.GetType();

            var properties = instanceType
              .GetProperties(BindingFlags.Public | BindingFlags.Instance)
              .Where(p =>
              p.PropertyType == typeof(ILog) && p.CanWrite && p.GetIndexParameters().Length == 0);

            foreach (var propToSet in properties)
            {
                switch (propToSet.Name)
                {
                    case "loggerDB":
                        propToSet.SetValue(instance, LogManager.GetLogger("DB"), null);
                        break;
                    default:
                        propToSet.SetValue(instance, LogManager.GetLogger(instanceType), null);
                        break;
                }
            }
        }

        protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
        {
            registration.Activated += (sender, e) => InjectLoggerProperties(e.Instance);
        }
    }
}
