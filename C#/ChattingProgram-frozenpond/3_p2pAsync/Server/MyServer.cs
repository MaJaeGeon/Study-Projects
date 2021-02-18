using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

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

            Console.WriteLine("Waiting for Client Connection..");

            TcpClient acceptClient = listener.AcceptTcpClient();
            Console.WriteLine("Client Connected");

            ClientData clientData = new ClientData(acceptClient);

            clientData.Client.GetStream().BeginRead(clientData.ReadByteData, 0, clientData.ReadByteData.Length, new AsyncCallback(DataReceived), clientData);

            while(true)
            {
                Console.WriteLine("running..");
                Thread.Sleep(1000);
            }
        }

        private void DataReceived(IAsyncResult ar)
        {
            ClientData callbackClient = ar.AsyncState as ClientData;

            int bytesRead = callbackClient.Client.GetStream().EndRead(ar);
            string readString = Encoding.Default.GetString(callbackClient.ReadByteData, 0, bytesRead);

            Console.WriteLine(readString);

            callbackClient.Client.GetStream().BeginRead(callbackClient.ReadByteData, 0, callbackClient.ReadByteData.Length, new AsyncCallback(DataReceived), callbackClient);
        }
    }
}
