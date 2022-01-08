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
        private Socket socket;
        private List<ClientHandler> clients = new List<ClientHandler>();
        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Start()
        {
            try
            {
                socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                socket.Listen(5);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = socket.Accept();
                    ClientHandler handler = new ClientHandler(clientSocket);
                    clients.Add(handler);
                    handler.OdjavljenKlijent += Handler_OdjavljenKlijent;
                    Thread clientThread = new Thread(handler.HandleRequests);
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        private void Handler_OdjavljenKlijent(object sender, EventArgs e)
        {
            clients.Remove((ClientHandler)sender);
        }

        public void Stop()
        {
            socket.Close();
            foreach(ClientHandler handler in clients)
            {
                handler.CloseSocket();
            }
            clients.Clear();
        }
    }
}
