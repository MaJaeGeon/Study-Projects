using System;
using System.Net.Sockets;

namespace Server
{
    class ClientData
    {
        public TcpClient Client { get; set; }
        public byte[] ReadByteData { get; set; }
        public int ClientNumber { get; set; }

        public ClientData(TcpClient client)
        {
            this.Client = client;
            this.ReadByteData = new byte[1024];

            string clientEndPoint = this.Client.Client.LocalEndPoint.ToString();
            char[] point = { '.', ':' };
            string[] splitedData = clientEndPoint.Split(point);

            this.ClientNumber = int.Parse(splitedData[3]);

            Console.WriteLine("{0}번 사용자 접속 성공", ClientNumber);
        }
    }
}
