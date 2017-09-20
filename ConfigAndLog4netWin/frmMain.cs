using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigAndLog4netWin
{
    public partial class frmMain : Form
    {
        //#injection
        public ILog logger { get; set; }
        public ILog loggerDB { get; set; }
        public Configuration.ConfigData configData { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoggerDebug_Click(object sender, EventArgs e)
        {
            logger.Debug(configData.field);
        }

        private void btnLoggerDBDebug_Click(object sender, EventArgs e)
        {
            loggerDB.Debug($"DB,{configData.field}");
        }

        private void btnfrmDebug_Click(object sender, EventArgs e)
        {
            frmDebug f = new frmDebug();
            //((Hierarchy)LogManager.GetRepository()).Root.AddAppender(f);
            ((Logger)LogManager.GetLogger("DB").Logger).AddAppender(f);
            f.Show();
        }

        private void btnGetAppenderCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Logger)LogManager.GetLogger("DB").Logger).Appenders.Count.ToString());
        }
    }
}
