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
using System.Diagnostics;

namespace GameShow
{
    public partial class GameShow : Form
    {
        static int socaudung = 0;
        string strNhan;
        int receiveID;
        public GameShow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //DarrenLee.LiveStream.Audio.Receiver audioReceiver = new DarrenLee.LiveStream.Audio.Receiver();
            //audioReceiver.Receive("127.0.0.1", 13000);
        }
        public string PlayerName
        {
            get { return strNhan; }
            set { strNhan = value; }
        }

        private void GameShow_Load_1(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + strNhan + " !!!";
           
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ConnectServer);
            thread.Start();
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }
        int socauhoi = 0;
        int q;
        string a, b, c, d;
        string answer = "";
        int second;
        string ketquadung;
        int i = 1;
        int win=0;
        TcpClient _client = null;
        Thread _thread = null;
        NetworkStream _ns = null;

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _client.Client.Shutdown(SocketShutdown.Send);
            _thread.Join();
            _ns.Close();
            _client.Close();
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
        }

        void ConnectServer()
        {
            IPAddress ip = IPAddress.Parse("192.168.100.5");
            int port = 5000;
            _client = new TcpClient();
            _client.Connect(ip, port);

            Console.WriteLine("client connected!!");
            _ns = _client.GetStream();
            _thread = new Thread(o => ReceiveData((TcpClient)o));
            _thread.Start(_client);
        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            string message = "Chat:" + strNhan + ":" + txbChat.Text;
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            _ns.Write(buffer, 0, buffer.Length);

            AddMessage("->" + strNhan + ":" + txbChat.Text);
            txbChat.Text = "";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            answer = btnA.Text;
            btnC.BackColor = SystemColors.Control;
            btnD.BackColor = SystemColors.Control;
            btnB.BackColor = SystemColors.Control;
            btnA.BackColor = Color.Yellow;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            answer = btnB.Text;
            //byte[] buffer = Encoding.ASCII.GetBytes(answer);
            //_ns.Write(buffer, 0, buffer.Length);
            //btnA.Enabled = false;
            //btnC.Enabled = false;
            //btnD.Enabled = false;
            //btnB.Enabled = false;
            btnC.BackColor = SystemColors.Control;
            btnD.BackColor = SystemColors.Control;
            btnA.BackColor = SystemColors.Control;
            btnB.BackColor = Color.Yellow;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            answer = btnC.Text;
            //byte[] buffer = Encoding.ASCII.GetBytes(answer);
            //_ns.Write(buffer, 0, buffer.Length);
            //btnB.Enabled = false;
            //btnA.Enabled = false;
            //btnD.Enabled = false;
            //btnC.Enabled = false;
            btnA.BackColor = SystemColors.Control;
            btnD.BackColor = SystemColors.Control;
            btnB.BackColor = SystemColors.Control;
            btnC.BackColor = Color.Yellow;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            answer = btnD.Text;
            //byte[] buffer = Encoding.ASCII.GetBytes(answer);
            //_ns.Write(buffer, 0, buffer.Length);
            //btnB.Enabled = false;
            //btnC.Enabled = false;
            //btnA.Enabled = false;
            //btnD.Enabled = false;
            btnC.BackColor = SystemColors.Control;
            btnA.BackColor = SystemColors.Control;
            btnB.BackColor = SystemColors.Control;
            btnD.BackColor = Color.Yellow;
        }

        private void GameShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Client.Shutdown(SocketShutdown.Send);
            _thread.Join();
            _ns.Close();
            _client.Close();
        }

        private void btnOpenStream_Click(object sender, EventArgs e)
        {
            Process.Start("demoReceiver.exe");
            btnOpenStream.Enabled = false;
        }

        void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                string data = Encoding.ASCII.GetString(receivedBytes, 0, byte_count);
                if (data.StartsWith("xx"))
                {
                    string[] N = data.Split(new string[] { "xx" }, StringSplitOptions.RemoveEmptyEntries);
                    string songuoichoi = N[0];
                    string songuoithang = N[1];
                    if (win ==1)
                    {
                        Result rs = new Result();
                        rs.nguoichoi = songuoichoi;
                        rs.nguoithang = songuoithang;
                        rs.tennguoichoi = strNhan;
                        //this.Hide();
                        //rs.Closed += (s, args) => this.Close();
                        rs.ShowDialog();
                    }
                    else
                    {
                        LoseForm rs = new LoseForm();
                        rs.nguoichoi = songuoichoi;
                        rs.nguoithang = songuoithang;
                        rs.tennguoichoi = strNhan;
                        //this.Hide();
                        //rs.Closed += (s, args) => this.Close();
                        rs.ShowDialog();
                    }
                }
                if (data=="Winner\r\n")
                {
                    string result = "WinChart";
                    byte[] buffer = Encoding.ASCII.GetBytes(result);
                    _ns.Write(buffer, 0, buffer.Length);
                    win = 1;
                }
                else if(data=="loser\r\n")
                {
                    string result = "WinChart";
                    byte[] buffer = Encoding.ASCII.GetBytes(result);
                    _ns.Write(buffer, 0, buffer.Length);
                    win = 0;
                }
                else if (data == "EndGame\r\n")
                {
                    MessageBox.Show("Game over !", "Game over !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string result = "KQ"+lbPoint.Text.Substring(8);
                    byte[] buffer = Encoding.ASCII.GetBytes(result);
                    _ns.Write(buffer, 0, buffer.Length);
                }
                else if (data.StartsWith("@@"))
                {
                    socauhoi++;
                    radLabel2.Text = socauhoi.ToString() + "/10";
                    btnA.Enabled = true;
                    btnB.Enabled = true;
                    btnC.Enabled = true;
                    btnD.Enabled = true;
                    btnA.BackColor = SystemColors.Control;
                    btnB.BackColor = SystemColors.Control;
                    btnC.BackColor = SystemColors.Control;
                    btnD.BackColor = SystemColors.Control;
                    lbCorrectAnswer.Text = "Correct answer:";
                    Thread count = new Thread(DoHeavyTasks);
                    count.Start();

                    string[] M = data.Split(new string[] { "@@" }, StringSplitOptions.RemoveEmptyEntries);

                    if (M.Length > 0)
                    {
                        lblQuestion.Invoke((MethodInvoker)(()
                            => lblQuestion.Text = i.ToString() + "." + M[0]));
                        btnA.Invoke((MethodInvoker)(()
                            => btnA.Text = M[1])); a = M[1].ToString();
                        btnA.Invoke((MethodInvoker)(()
                           => btnB.Text = M[2])); b = M[2].ToString();
                        btnC.Invoke((MethodInvoker)(()
                           => btnC.Text = M[3])); c = M[3].ToString();
                        btnD.Invoke((MethodInvoker)(()
                           => btnD.Text = M[4])); d = M[4].ToString();
                        //ketquadung = M[5].ToString();
                        i++;
                        //lsvMessage.Items.Add("asd");      

                    }
                }
                else
                {
                    if (data.StartsWith("Chat:"))
                    {
                        string messa = data.Substring(5);
                        AddMessage(messa);
                    }
                    else
                    {
                        while (true)
                        {
                            if (second == 0)
                            {
                                if (data.StartsWith("+"))
                                {
                                    string[] M = data.Split(new string[] { "+" }, StringSplitOptions.RemoveEmptyEntries);
                                    socaudung = socaudung + Int32.Parse(M[0]);
                                    lbPoint.Text = "Correct:" + socaudung.ToString();
                                    lbCorrectAnswer.Text ="Correct answer:"+ M[1].ToString();
                                    string rs = M[1].ToString();
                                    if (a == rs)
                                    {
                                        btnA.BackColor = Color.LightGreen;
                                    }
                                    if (b == rs)
                                    {
                                        btnB.BackColor = Color.LightGreen;
                                    }
                                    if (c == rs)
                                    {
                                        btnC.BackColor = Color.LightGreen;
                                    }
                                    if (d == rs)
                                    {
                                        btnD.BackColor = Color.LightGreen;
                                    }
                                    break;
                                }


                            }
                        }
                    }
                }

            }
        }
        void AddMessage(string s)
        {
            lsbChat.Items.Add(s);
            lsbChat.SelectedIndex = lsbChat.Items.Count - 1;
            lsbChat.SelectedIndex = -1;
        }
        void DoHeavyTasks()
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                second = i;
                lbCountDown.Text = i.ToString();
                if (second == 0)
                {
                    btnA.Enabled = false;
                    btnB.Enabled = false;
                    btnC.Enabled = false;
                    btnD.Enabled = false;
                    byte[] buffer = Encoding.ASCII.GetBytes(answer);
                    _ns.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
