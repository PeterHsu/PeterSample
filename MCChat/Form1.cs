using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCChat
{
    public partial class Form1 : Form
    {
        UdpClient client = null;
        IPEndPoint multiCastEP = null;

        #region 初始
        public Form1()
        {
            InitializeComponent();
        }
        #endregion 初始

        #region 表單事件
        private void btnJoin_Click(object sender, EventArgs e)
        {
            IPAddress group = IPAddress.Parse(txtGroupID.Text.Trim());
            int port = int.Parse(txtPort.Text.Trim());

            client = new UdpClient(port);
            client.JoinMulticastGroup(group, 10);
            multiCastEP = new IPEndPoint(group, port);

            ReceiveMessage();

            SendMessage("加入聊天室");
        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage(txtMessage.Text);
        }
        #endregion 表單事件

        #region private
        private void SendMessage(string message)
        {
            byte[] buff;
            buff = Encoding.UTF8.GetBytes($"{txtName.Text} - {message}");
            client.Send(buff, buff.Length, multiCastEP);
        }

        private async void ReceiveMessage()
        {
            while(true)
            {
                var result = await client.ReceiveAsync();
                string message = Encoding.UTF8.GetString(result.Buffer);
                UpdateUI_listBox1(message);
            }
        }
        private void UpdateUI_listBox1(string message)
        {
            this.Invoke(new Action(() => {
                listBox1.Items.Add(message);
            }));
        }
        #endregion private


    }
}
