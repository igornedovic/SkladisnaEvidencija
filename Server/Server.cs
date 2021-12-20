using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket listener;
        private List<ClientHandler> clients = new List<ClientHandler>();
        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            listener.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
        }

        public void Listen()
        {
            listener.Listen(5);
            bool kraj = false;
            while (!kraj)
            {
                try
                {
                    Socket client = listener.Accept();
                    ClientHandler handler = new ClientHandler(client);
                    clients.Add(handler);
                    Thread thread = new Thread(handler.StartHandler);
                    thread.IsBackground = true;
                    thread.Start();
                }
                catch (SocketException)
                {
                    Debug.WriteLine("Kraj rada!");
                    kraj = true;
                }
            }
        }

        public void Stop()
        {
            listener.Close();
            foreach(ClientHandler c in clients)
            {
                c.Stop();
            }
            clients.Clear();
        }
    }
}
