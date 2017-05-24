using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigAndLog4net
{
class Program
{
    internal static readonly ILog logger = LogManager.GetLogger(typeof(Program));
    static void Main(string[] args)
    {
        logger.Debug("Hello, Log4net");
    }
}
}
