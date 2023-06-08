using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoTransmitter
{
    public partial class MainWindow : Form
    {
        //коллекция обнаруженных видеоустройств в системе
        private FilterInfoCollection _videoDevicesInfo;

        //ссылка на видео устройство
        private VideoCaptureDevice _videoDevice;


        private static IPEndPoint _iPEndPoint;
        private static UdpClient _udpClient;
        private static bool _isTransmit = false;
        public MainWindow()
        {
            InitializeComponent();
            _videoDevicesInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (_videoDevicesInfo.Count == 0)
            {
                toolStripStatusLabel_Info.ForeColor = Color.Red;
                toolStripStatusLabel_Info.Text = "Видео устройства не обнаружены";
                return;
            }

            foreach (FilterInfo item in _videoDevicesInfo)
            {
                comboBox_VideoDevices.Items.Add(item.Name);
            }
        }

        private void comboBox_VideoDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValueName = comboBox_VideoDevices.SelectedItem.ToString();

            foreach (FilterInfo item in _videoDevicesInfo)
            {
                if (selectedValueName == item.Name)
                {
                    _videoDevice = new VideoCaptureDevice(item.MonikerString);

                    //событие генерирования нового видео кадра
                    _videoDevice.NewFrame += _videoDevice_NewFrame;
                }
            }
        }

       

        private void button_VideoDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (_videoDevice.IsRunning)
                {
                    _videoDevice.Stop();
                    button_VideoDevice.Text = "Start";
                    comboBox_VideoDevices.Enabled = true;
                    pictureBox_TV.Image = null;
                    pictureBox_TV.Refresh();
                    //Ввертуться к стандартной картинке
                }
                else
                {
                    if (comboBox_VideoDevices.SelectedItem != null)
                    {
                        button_VideoDevice.Text = "Stop";
                        comboBox_VideoDevices.Enabled = false;
                        _videoDevice.Start();
                    }
                    else
                    {
                        MessageBox.Show("Выберите видео устройство", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_videoDevice != null && _videoDevice.IsRunning)
            {
                _videoDevice.Stop();
            }
        }


        private void _videoDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            var bmp = new Bitmap(eventArgs.Frame, pictureBox_TV.Width, pictureBox_TV.Height);
            MemoryStream memoryStream = new MemoryStream();
            bmp.Save(memoryStream,
                    ImageCodecInfo.GetImageEncoders()[1],
                    new EncoderParameters()
                    {
                        Param = new EncoderParameter[]
                            {
                                    new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, 100L)
                            }
                    }
            );

            var img = new Bitmap(memoryStream);
            pictureBox_TV.Image = img;
        }

        private void button_StartTransmitt_Click(object sender, EventArgs e)
        {
            try
            {
                if (_videoDevice != null && _videoDevice.IsRunning && _isTransmit == false)
                {
                    IPAddress iPAddress;
                    if(IPAddress.TryParse(textBox_IpAdress.Text, out iPAddress)) {
                        _iPEndPoint = new IPEndPoint(iPAddress, Convert.ToInt32(textBox_Port.Text));
                        _udpClient = new UdpClient();
                        _isTransmit = true;
                        toolStripStatusLabel_Info.ForeColor = Color.Green;
                        textBox_IpAdress.ReadOnly = true;
                        textBox_Port.ReadOnly = true;
                        button_StartTransmitt.Text = "Stop";
                        toolStripStatusLabel_Info.Text = "Трансляция запущена";
                        _videoDevice.NewFrame += _videoDevice_NewFrameTransmit;
                    } else
                    {
                        toolStripStatusLabel_Info.ForeColor = Color.Red;
                        toolStripStatusLabel_Info.Text = "IP адресс не валиден, трансляйция не возможна";
                        return;
                    }
                } else if (_isTransmit)
                {
                    //останавливаем трансляцию
                    _isTransmit = false;
                    toolStripStatusLabel_Info.Text = "Трансляция остановлена";
                    button_StartTransmitt.Text = "Transmit";
                }
                else
                {
                    toolStripStatusLabel_Info.ForeColor = Color.Red;
                    toolStripStatusLabel_Info.Text = "Выберите видеоустройство. И влючите его";
                }
            }
            catch(FormatException fEx)
            {
                toolStripStatusLabel_Info.ForeColor = Color.Red;
                toolStripStatusLabel_Info.Text = fEx.Message;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel_Info.ForeColor = Color.Red;
                toolStripStatusLabel_Info.Text = ex.Message;
            }
        }

        //трансляция сигнала по сети
        private void _videoDevice_NewFrameTransmit(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            if ( _isTransmit)
            {
                var bmp = new Bitmap(eventArgs.Frame, pictureBox_TV.Width, pictureBox_TV.Height);
                MemoryStream memoryStream = new MemoryStream();

                bmp.Save(memoryStream, 
                        ImageCodecInfo.GetImageEncoders()[1], 
                        new EncoderParameters()
                        {
                            Param = new EncoderParameter[]
                                {
                                    new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, 100L)
                                }
                        }
                );
                byte[] bytes = memoryStream.ToArray();
                _udpClient.Send(bytes, bytes.Length, _iPEndPoint);
                memoryStream.Close();
            } 
        }
    }
}
