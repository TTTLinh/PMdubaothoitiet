using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        public class Server
        {
            private const int BUFFER_SIZE = 1024;
            private const int PORT_NUMBER = 9999;

            static ASCIIEncoding encoding = new ASCIIEncoding();

            public static void Main()
            {
                Console.OutputEncoding = Encoding.UTF8;
                try
                {
                    IPAddress address = IPAddress.Parse("127.0.0.1");

                    TcpListener listener = new TcpListener(address, PORT_NUMBER);

                    // 1. listen
                    listener.Start();

                    Console.WriteLine("Server bắt đầu kết nối tới IEP là:  " + listener.LocalEndpoint);
                    Console.WriteLine("Đang chờ kết nối ...");

                    Socket socket = listener.AcceptSocket();
                    Console.WriteLine("Kết nối nhận được từ " + socket.RemoteEndPoint);

                    // 2. receive

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                Console.Read();
            }
        }
    }
}
