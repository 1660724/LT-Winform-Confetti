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
        static int songuoichoi = -1;
        static List<string> useridVideo = new List<string>();
        static void Main(string[] args)
        {

            int count = 1;

            TcpListener ServerSocket = new TcpListener(IPAddress.Any, 6000);
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

        static int songuoithang = 0;
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
                Console.WriteLine(data);
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
