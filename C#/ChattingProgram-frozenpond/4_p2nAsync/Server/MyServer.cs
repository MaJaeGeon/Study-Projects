using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    class MyServer
    {
        public MyServer()
        {
            AsyncServerStart();
        }

        private void AsyncServerStart()
        {
            TcpListener listener = new TcpListener(new IPEndPoint(IPAddress.Any, 9999));

            listener.Start();
            Console.WriteLine("Starting Server..");

            while(true)
            {
                TcpClient acceptClient = listener.AcceptTcpClient();

                ClientData clientData = new ClientData(acceptClient);

                clientData.Client.GetStream().BeginRead(clientData.ReadByteData, 0, clientData.ReadByteData.Length, new AsyncCallback(DataReceived), clientData);
            }
        }

        private void DataReceived(IAsyncResult ar)
        {
            ClientData callbackClient = ar.AsyncState as ClientData;

            int bytesRead = callbackClient.Client.GetStream().EndRead(ar);
            string readString = Encoding.Default.GetString(callbackClient.ReadByteData, 0, bytesRead);

            Console.WriteLine("{0}번 사용자 : {1}", callbackClient.ClientNumber, readString);

            callbackClient.Client.GetStream().BeginRead(callbackClient.ReadByteData, 0, callbackClient.ReadByteData.Length, new AsyncCallback(DataReceived), callbackClient);
        }
    }
}
