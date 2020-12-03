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

namespace demoSender
{
    
    public partial class Form1 : Form
    {
        int confID;
        int userIDHost;
        int userID1;
        int userID2;
        int userID3;
        int userID4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axVideoChatServer1.InitServer(1234, 900);
            axVideoChatServer1.UseRandomNumber = false;
            confID = axVideoChatServer1.CreateConference();
            userIDHost = axVideoChatServer1.AddUser(confID);
            userID1 = axVideoChatServer1.AddUser(confID);
            userID2 = axVideoChatServer1.AddUser(confID);
            userID3 = axVideoChatServer1.AddUser(confID);
            userID4 = axVideoChatServer1.AddUser(confID);
            //button1.Enabled = false;
            btnConnectVideo.Enabled = false;
           
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            axVideoChatServer1.UnInitServer();
            _client.Client.Shutdown(SocketShutdown.Send);
            _thread.Join();
            _ns.Close();
            _client.Close();
        }


        TcpClient _client = null;
        Thread _thread = null;
        NetworkStream _ns = null;
        void ConnectServer()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 6000;
            _client = new TcpClient();
            _client.Connect(ip, port);

            Console.WriteLine("client connected!!");
            _ns = _client.GetStream();
            _thread = new Thread(o => ReceiveData((TcpClient)o));
            _thread.Start(_client);
        }

        void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                string data = Encoding.ASCII.GetString(receivedBytes, 0, byte_count);                
                Console.Write(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
                
            }
        }


        private void btnConnectServer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ConnectServer);
            thread.Start();
            btnConnectServer.Enabled = false;
        }

        private void btnBroadcast_Click(object sender, EventArgs e)
        {
            string dataVideo = string.Format("tk{0}tk{1}tk{2}tk{3}tk", userID1, userID2, userID3, userID4);
            byte[] buffer = Encoding.ASCII.GetBytes(dataVideo);
            _ns.Write(buffer, 0, buffer.Length);
            btnBroadcast.Enabled = false;

            axVideoChatSender1.VideoDevice = 0;
            axVideoChatSender1.AudioDevice = 0;
            axVideoChatSender1.VideoFormat = 0;
            axVideoChatSender1.FrameRate = 15;
            axVideoChatSender1.VideoBitrate = 128000;
            axVideoChatSender1.AudioComplexity = 0;
            axVideoChatSender1.AudioQuality = 8;
            axVideoChatSender1.SendAudioStream = true;
            axVideoChatSender1.SendVideoStream = true;
            axVideoChatSender1.ConferenceNumber = confID;
            axVideoChatSender1.ConferenceUserID = userIDHost;
            axVideoChatSender1.Connect("127.0.0.1", 1234);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
