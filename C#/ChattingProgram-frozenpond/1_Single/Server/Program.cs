using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server Console \n\n\n");

            TcpListener server = new TcpListener(IPAddress.Any, 9999);
            server.Start();

            TcpClient client = server.AcceptTcpClient();

            byte[] byteData = new byte[1024];

            client.GetStream().Read(byteData, 0, byteData.Length);

            Console.WriteLine(Encoding.Default.GetString(byteData));

            server.Stop();
            client.Close();
        }
    }
}
