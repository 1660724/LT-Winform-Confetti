using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static readonly object _lock = new object();
        static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();
        static List<string> questionlist = new List<string>();
        static string ketqua;
        static int songuoichoi=-1;
        static List<string> useridVideo = new List<string>();
        static void Main(string[] args)
        {

            int count = 1;

            TcpListener ServerSocket = new TcpListener(IPAddress.Any, 5000);
            ServerSocket.Start();

            while (true)
            {
                TcpClient client = ServerSocket.AcceptTcpClient();
                lock (_lock) list_clients.Add(count, client);
                Console.WriteLine("Someone connected!!");
                songuoichoi++;
                Thread t = new Thread(handle_clients);
                t.Start(count);
                
                count++;
            }
        }

        static int songuoithang=0;
        public static void handle_clients(object o)
        {

            int id = (int)o;
            TcpClient client;

            lock (_lock) client = list_clients[id];

            while (true)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int byte_count = stream.Read(buffer, 0, buffer.Length);
                if (byte_count == 0)
                {
                    break;
                }

                string data = Encoding.ASCII.GetString(buffer, 0, byte_count);
                if (data.StartsWith("ConVid"))
                {
                    string s = "tkv" + useridVideo[0] + "tkv";
                    useridVideo.Remove(useridVideo[0]);
                    foreach (KeyValuePair<int, TcpClient> c in list_clients)
                    {
                        if (c.Value == client)
                        {
                            broadcast(s, c);
                        }
                    }
                }
                else if (data.StartsWith("tk"))
                {
                    string[] M = data.Split(new string[] { "tk" }, StringSplitOptions.RemoveEmptyEntries);
                    useridVideo.Add(M[0]);
                    useridVideo.Add(M[1]);
                    useridVideo.Add(M[2]);
                    useridVideo.Add(M[3]);
                }
                else if (data=="WinChart")
                {
                    string chart = "xx" + songuoichoi.ToString() + "xx" + songuoithang.ToString() + "xx";
                    foreach (KeyValuePair<int, TcpClient> c in list_clients)
                    {
                        if (c.Value == client)
                        {
                            broadcast(chart, c);
                        }
                    }
                }
                else if (data.StartsWith("KQ"))
                {
                    int sl =Int32.Parse(data.Substring(2));
                    if (sl==1)
                    {
                        songuoithang++;
                        foreach (KeyValuePair<int, TcpClient> c in list_clients)
                        {
                            if (c.Value == client)
                            {
                                broadcast("Winner", c);
                            }
                        }
                        Console.WriteLine(songuoithang);
                        Console.WriteLine(songuoichoi);
                    }
                    else
                    {
                        foreach (KeyValuePair<int, TcpClient> c in list_clients)
                        {
                            if (c.Value == client)
                            {
                                broadcast("loser", c);
                            }
                        }
                    }
                }
                else if (data.StartsWith("@@"))
                {
                    Console.WriteLine("Vao ham xu ly chuoi");
                    string[] M = data.Split(new string[] { "@@" }, StringSplitOptions.RemoveEmptyEntries);
                    ketqua = M[5];
                    string data1 = "@@" + M[0] + "@@" + M[1] + "@@" + M[2] + "@@" + M[3] + "@@" + M[4] + "@@";
                    foreach (KeyValuePair<int, TcpClient> c in list_clients)
                    {
                        if (c.Value != client)
                        {
                            broadcast(data, c);
                        }
                    }
                    Console.WriteLine("ket thuc ham xu ly chuoi");
                }
                else
                {
                    if (data.StartsWith("Chat:"))
                    {
                        foreach (KeyValuePair<int, TcpClient> c in list_clients)
                        {
                            if (c.Value != client)
                            {
                                broadcast(data, c);
                            }
                        }
                    }
                    else
                    {
                        if (data == "EndGame")
                        {
                            foreach (KeyValuePair<int, TcpClient> c in list_clients)
                            {
                                if (c.Value != client)
                                {
                                    broadcast(data, c);
                                }
                            }
                            Console.WriteLine("tro choi ket thuc");
                        }

                        else if (data == ketqua)
                        {
                            Console.WriteLine("vao ham xu ly ket qua");
                            Console.WriteLine(data);
                            foreach (KeyValuePair<int, TcpClient> c in list_clients)
                            {
                                if (c.Value == client)
                                {
                                    broadcast("+1+" + ketqua + "+", c);
                                }
                            }
                            Console.WriteLine("ket thuc ham xu ly kq");
                        }
                        else
                        {
                            foreach (KeyValuePair<int, TcpClient> c in list_clients)
                            {
                                if (c.Value == client)
                                {
                                    broadcast("+0+" + ketqua + "+", c);
                                }
                            }
                            Console.WriteLine("ket thuc ham xu ly kq");
                        }

                    }

                }
                Console.WriteLine(data);


            }

            lock (_lock) list_clients.Remove(id);
            client.Client.Shutdown(SocketShutdown.Both);
            client.Close();
        }

        public static void broadcast(string data, KeyValuePair<int, TcpClient> c)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(data + Environment.NewLine);

            lock (_lock)
            {
                System.Net.Sockets.NetworkStream stream = c.Value.GetStream();
                stream.Write(buffer, 0, buffer.Length);
            }

        }
    }
}
