using System;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        static TcpClient client = null;

        private static void SendMessage()
        {
            Console.WriteLine("보낼 메시지를 입력해주세요.");
            string message = Console.ReadLine();

            byte[] byteData = new byte[message.Length];
            byteData = Encoding.Default.GetBytes(message);

            client.GetStream().Write(byteData, 0, byteData.Length);
            Console.WriteLine("전송성공");
            Console.ReadKey();
        }

        private static void Connect()
        {
            client = new TcpClient();

            client.Connect("127.0.0.1", 9999);
            Console.WriteLine("서버 연결 성공!");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("==========클라이언트==========");
                Console.WriteLine("1.서버연결");
                Console.WriteLine("2.Message 보내기");
                Console.WriteLine("==============================");

                string key = Console.ReadLine();
                int order = 0;

                if (int.TryParse(key, out order))
                {
                    switch (order)
                    {
                        case 1:
                            {
                                if (client != null)
                                {
                                    Console.WriteLine("이미 연결되어있습니다.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Connect();
                                }
                                break;
                            }

                        case 2:
                            {
                                if (client == null)
                                {
                                    Console.WriteLine("먼저 서버와 연결해주세요.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    SendMessage();
                                }

                                break;
                            }

                        default:
                            {
                                Console.WriteLine("잘못 입력하셨습니다.");
                                Console.ReadKey();

                                break;
                            }
                    }
                }
            }
        }
    }
}
