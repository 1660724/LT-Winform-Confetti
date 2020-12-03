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

namespace demoReceiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "ConVidFromClient";
            byte[] buffer = Encoding.ASCII.GetBytes(s);
            _ns.Write(buffer, 0, buffer.Length);
            ///
            btnConnectVideo.Enabled = false;
        }



        TcpClient _client = null;
        Thread _thread = null;
        NetworkStream _ns = null;
        void ConnectServer()
        {
            IPAddress ip = IPAddress.Parse("192.168.100.5");
            int port = 6000;
            _client = new TcpClient();
            _client.Connect(ip, port);

            Console.WriteLine("client connected!!");
            _ns = _client.GetStream();
            _thread = new Thread(o => ReceiveData((TcpClient)o));
            _thread.Start(_client);
        }
        int receiveID;
        void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                string data = Encoding.ASCII.GetString(receivedBytes, 0, byte_count);

                if(data.StartsWith("tkv"))
                {
                    string[] N = data.Split(new string[] { "tkv" }, StringSplitOptions.RemoveEmptyEntries);
                    label1.Text = N[0];
                    receiveID = Int32.Parse(N[0]);
                }
                Console.Write(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ConnectServer);
            thread.Start();
            btnConnect.Enabled = false;
        }

        private void btnReceiveStream_Click(object sender, EventArgs e)
        {
            axVideoChatReceiver1.ConferenceNumber = 5000;
            axVideoChatReceiver1.ConferenceUserID = receiveID;
            axVideoChatReceiver1.VideoWindowAutoMax = true;
            axVideoChatReceiver1.ReceiveAudioStream = true;
            axVideoChatReceiver1.ReceiveVideoStream = true;
            axVideoChatReceiver1.Listen("192.168.100.5", 1234);
            btnReceiveStream.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Client.Shutdown(SocketShutdown.Send);
            _thread.Join();
            _ns.Close();
            _client.Close();
        }
    }
}
