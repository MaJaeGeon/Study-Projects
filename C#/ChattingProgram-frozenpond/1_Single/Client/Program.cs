using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client Console \n\n\n");

            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 9999);

            byte[] buf = Encoding.Default.GetBytes("클라이어트 : 접속합니다.");

            client.GetStream().Write(buf, 0, buf.Length);

            client.Close();
        }
    }
}
