using System;
using System.Diagnostics;

namespace FileUploadServer
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("사용법 : {0} <Directory>", Process.GetCurrentProcess().ProcessName);

                return;
            }

            uint msgId = 0;
        }
    }
}
