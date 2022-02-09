using Projekat.Common.Communication;
using Projekat.Common.Domain;
using Projekat.Server.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private CommunicationHelper helper;
        private bool kraj = false;

        public EventHandler OdjavljenKlijent;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }

        internal void HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Receive<Request>();
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }

        private Response CreateResponse(Request request)
        {
            Response response = new Response();

            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controller.Instance.Login((Admin)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.IsSuccessful = false;
                            response.Message = "Pogresni kredencijali!";
                        }
                        break;
                    case Operation.UcitajPoslovnePartnere:
                        response.Result = Controller.Instance.UcitajPoslovnePartnere();
                        break;
                    case Operation.UcitajProizvode:
                        response.Result = Controller.Instance.UcitajProizvode();
                        break;
                    case Operation.UnesiMagacinskiDokument:
                        Controller.Instance.UnesiMagacinskiDokument((Dokument)request.RequestObject);
                        break;
                    case Operation.End:
                        kraj = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                response.IsSuccessful = false;
                response.Message = ex.Message;
            }

            return response;
        }

        private static object lockObject = new object();
        internal void CloseSocket()
        {
            if (socket != null)
            {
                lock (lockObject)
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
}
