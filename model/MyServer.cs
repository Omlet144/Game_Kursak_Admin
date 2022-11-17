using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Game_Kursak_Admin.model
{
    internal class MyServer
    {
        static TcpListener tcpListener;
        public List<MyClient> clients { get; set; }
        readonly int PORT;
        public string msg;

        public MyServer(int port = 8008)
        {
            clients = new List<MyClient>();
            this.PORT = port;
        }

        internal void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, PORT);
                tcpListener.Start();

                while (true)
                {

                    TcpClient client = tcpListener.AcceptTcpClient();
                    MyClient myClient = new MyClient(client, this);
                    Thread clientThread = new Thread(new ThreadStart(myClient.Work));
                    clientThread.Start();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                CloseServer();
            }
        }

        internal void DeleteConnetion(string id)
        {
            MyClient client = clients.FirstOrDefault(x => x.Id.Equals(id));
            if (client != null)
                clients.Remove(client);
        }

        internal void AddConnection(MyClient myClient)
        {
            clients.Add(myClient);
        }

        internal void CloseServer()
        {
            tcpListener.Stop();
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].Close();
            }
        }
    }
}
