using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace GameShowMC
{
    public partial class ConfettiMC : Form
    {

        public ConfettiMC()
        {
            InitializeComponent();
            //DarrenLee.LiveStream.Audio.Sender audioSender = new DarrenLee.LiveStream.Audio.Sender();
            //audioSender.Send("192.168.100.14",13000);
        }

        TcpClient _client = null;
        Thread _thread = null;
        NetworkStream _ns = null;
        void ConnectServer()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 5000;
            _client = new TcpClient();
            _client.Connect(ip, port);

            Console.WriteLine("client connected!!");
            _ns = _client.GetStream();
            _thread = new Thread(o => ReceiveData((TcpClient)o));
            _thread.Start(_client);
        }
        static string mess;
        void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                string data = Encoding.ASCII.GetString(receivedBytes, 0, byte_count);
                if (data.StartsWith("Chat:"))
                {
                    mess = data.Substring(5);
                    AddMessage(mess);
                }
                else
                {
                    Console.Write(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
                }
            }
        }

        void AddMessage(string s)
        {
            lsbChat.Items.Add(s);
            lsbChat.SelectedIndex = lsbChat.Items.Count - 1;
            lsbChat.SelectedIndex = -1;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ConnectServer);
            thread.Start();
            materialFlatButton1.Enabled = false;
            materialFlatButton2.Enabled = true;
        }
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            _client.Client.Shutdown(SocketShutdown.Send);
            _thread.Join();
            _ns.Close();
            _client.Close();
            materialFlatButton2.Enabled = false;
            materialFlatButton1.Enabled = true;

        }


        int socauhoi = 0;
        List<Question> _lstQuestions;
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            string path = "question.txt";
            string[] lines = File.ReadAllLines(path);

            _lstQuestions = new List<Question>();
            Question question = null;
            foreach (string line in lines)
            {
                if (line.StartsWith("@@"))//Question
                {
                    question = new Question();
                    question.Content = line.Substring(2);
                }
                if (line.StartsWith("--"))//Image
                {
                    question.ImageLink = line.Substring(2);
                }
                if (line.StartsWith("$$"))//Answer
                {
                    //Answer answer = new Answer();
                    //string []M = line.Substring(2).Split(new char[] { '.' });
                    //answer.Id = M[0];
                    //answer.Content = M[1];
                    question.ListAnswers.Add(line.Substring(2));
                    //question.ListAnswers.Add(answer);
                }
                if (line.StartsWith("**"))
                {
                    question.CorrectAnswer = line.Substring(2);
                }
                if (line.StartsWith("##"))
                {
                    _lstQuestions.Add(question);
                    socauhoi++;
                }
                
            }
            Load_Ques();
            btnLoadQuestion.Enabled = false;
            btnNext.Enabled = false;
            Thread countdown = new Thread(DoHeavyTasks);
            countdown.Start();
        }
        int index = 0;
        void Load_Ques()
        {
            Question question = _lstQuestions[index];
            rtbQuestion.Text = question.Content;
            txtA.Text = question.ListAnswers[0];
            txtB.Text = question.ListAnswers[1];
            txtC.Text = question.ListAnswers[2];
            txtD.Text = question.ListAnswers[3];
            txtCorrect.Text = question.CorrectAnswer;
            index++;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string question = rtbQuestion.Text;
            string a = txtA.Text;
            string b = txtB.Text;
            string c = txtC.Text;
            string d = txtD.Text;
            string f = txtCorrect.Text;
            string data = string.Format("@@{0}@@{1}@@{2}@@{3}@@{4}@@{5}@@"
                , question, a, b, c, d, f);
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            _ns.Write(buffer, 0, buffer.Length);
            btnSend.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index == socauhoi)
            {
                index = socauhoi - 1;
                MessageBox.Show("Out of questions !", "End !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext.Enabled = false;
                btnSend.Enabled = false;
                txbChat.Focus();
            }
            else
            {
                Question question = _lstQuestions[index];

                rtbQuestion.Text = question.Content;
                txtA.Text = question.ListAnswers[0];
                txtB.Text = question.ListAnswers[1];
                txtC.Text = question.ListAnswers[2];
                txtD.Text = question.ListAnswers[3];
                txtCorrect.Text = question.CorrectAnswer;
                btnSend.Enabled = true;
                index++;
            }
            btnNext.Enabled = false;
            Thread countdown = new Thread(DoHeavyTasks);
            countdown.Start();
        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            string message = "Chat:+Host:" + txbChat.Text;
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            _ns.Write(buffer, 0, buffer.Length);
            AddMessage("->Host:" + txbChat.Text);
            txbChat.Text = "";
        }
        int second;
        void DoHeavyTasks()
        {
            for (int i = 15; i >= 0; i--)
            {
                Thread.Sleep(1000);
                second = i;
                lbCountDown.Text = i.ToString();
                if (second == 0)
                {
                    btnNext.Enabled = true; 
                }
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            string data = string.Format("EndGame");
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            _ns.Write(buffer, 0, buffer.Length);
        }
        
       

        private void ConfettiMC_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOpenStream_Click(object sender, EventArgs e)
        {
            Process.Start("demoServer.exe");
            Process.Start("demoSender.exe");
            btnOpenStream.Enabled = false;
        }
    }
}
