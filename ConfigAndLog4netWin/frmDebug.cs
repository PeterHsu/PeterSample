using log4net.Appender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Core;
using log4net;
using log4net.Repository.Hierarchy;

namespace ConfigAndLog4netWin
{
    public partial class frmDebug : Form, IAppender
    {
        public frmDebug()
        {
            InitializeComponent();
        }

        public void DoAppend(LoggingEvent loggingEvent)
        {
            BeginInvoke(new Action(() =>
            {
                lstDebug.Items.Add(string.Format("name={0},date={1},level{2},thread={3},message={4}",
                    loggingEvent.LoggerName,
                    loggingEvent.TimeStamp,
                    loggingEvent.Level,
                    loggingEvent.ThreadName,
                    loggingEvent.RenderedMessage
                    ));
                if (lstDebug.Items.Count > 20)
                {
                    lstDebug.Items.RemoveAt(0);
                }
            }));
        }

        private void frmDebug_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Logger)LogManager.GetLogger("DB").Logger).RemoveAppender(this);
        }
    }
}
