using System.Net.Sockets;

namespace Server
{
    internal class ClientData
    {
        public TcpClient Client { get; set; }
        public byte[] ReadByteData { get; set; }

        public ClientData(TcpClient acceptClient)
        {
            this.Client = acceptClient;
            this.ReadByteData = new byte[1024];
        }
    }
}