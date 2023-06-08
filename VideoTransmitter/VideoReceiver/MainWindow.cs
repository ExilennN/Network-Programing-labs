using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoReceiver
{
    public partial class MainWindow : Form
    {
        private static CancellationToken _cts = new CancellationToken();
        private static bool _isReceiveBegin = false;
        private IPEndPoint _iPEndPoint;
        private UdpClient _udpClient;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Receive_Click(object sender, EventArgs e)
        {
            IPAddress iPAddress;
            if (!_isReceiveBegin)
            {
                if (IPAddress.TryParse(textBox_IP.Text, out iPAddress))
                {
                    _iPEndPoint = new IPEndPoint(iPAddress, Convert.ToInt32(textBox_Port.Text));

                    toolStripStatusLabel_Info.ForeColor = Color.Green;
                    textBox_IP.ReadOnly = true;
                    textBox_Port.ReadOnly = true;

                    button_Receive.Text = "Stop";
                    toolStripStatusLabel_Info.Text = "Принятие видеопотока запущено";

                    RecieveVideoContentAsync();
                    _isReceiveBegin = true;
                    if(_udpClient != null) _udpClient.Close();
                }
                else
                {
                    toolStripStatusLabel_Info.ForeColor = Color.Red;
                    toolStripStatusLabel_Info.Text = "IP адресс не валиден, трансляйция не возможна";
                    return;
                }
            } else
            {
                _isReceiveBegin = false;
                button_Receive.Text = "Receive";
                textBox_IP.ReadOnly = false;
                textBox_Port.ReadOnly = false;
                pictureBox_TV.Image = null;
                pictureBox_TV.Refresh();
            }
        }

        private async void RecieveVideoContentAsync()
        {
            await Task.Run(async () =>
             {
                 _udpClient = new UdpClient(_iPEndPoint);
                 while (_isReceiveBegin)
                 {
                     var data = await _udpClient.ReceiveAsync();
                     MemoryStream memoryStream = new MemoryStream(data.Buffer);

                     pictureBox_TV.Image = new Bitmap(memoryStream);

                     pictureBox_TV.Invalidate();
                 }
             });
        }
    }
}
