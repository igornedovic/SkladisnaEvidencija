using Forme.Exceptions;
using Projekat.Common.Communication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Forme.ServerCommunication
{
    public class Communication
    {
        private static Communication instance;
        private Socket socket;
        private CommunicationHelper helper;

        private Communication() { }

        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        public Output SendRequestGetResult<Output>(Operation operation, object requestObject = null) where Output : class
        {
            SendRequest(operation, requestObject);
            return GetResult<Output>();
        }

        public void SendRequestNoResult(Operation operation, object requestObject)
        {
            SendRequest(operation, requestObject);
            GetResult();
        }

        private T GetResult<T>() where T : class
        {
            Response response = helper.Receive<Response>();
            if (response.IsSuccessful)
            {
                return (T)response.Result;
            }
            else
            {
                throw new SystemOperationException(response.Message);
            }
        }

        private void GetResult()
        {
            Response response = helper.Receive<Response>();
            if (!response.IsSuccessful)
            {
                throw new SystemOperationException(response.Message);
            }
        }

        private void SendRequest(Operation operation, object requestObject = null)
        {
            try
            {
                Request r = new Request
                {
                    Operation = operation,
                    RequestObject = requestObject
                };
                helper.Send(r);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }

        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);

            }
        }

        public void Close()
        {
            if (socket == null) return;
            Request request = new Request
            {
                Operation = Operation.End,
            };
            helper.Send(request);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }
    }
}
