using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private bool kraj = false;

        public EventHandler OdjavljenKlijent;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
        }

        internal void HandleRequests()
        {
            throw new NotImplementedException();
        }

        internal void CloseSocket()
        {
            if (socket != null)
            {
                kraj = true;
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
                OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
