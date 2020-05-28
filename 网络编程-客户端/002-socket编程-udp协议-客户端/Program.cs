using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _002_socket编程_udp协议_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建socket
            Socket udpClient = new Socket
                (AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);

            while (true)
            {
                //发送数据
                EndPoint serverPoint = new IPEndPoint(IPAddress.Parse("192.222.60.176"), 7788);
                string message = Console.ReadLine();
                Console.WriteLine("客户端发送一条数据：" + message);
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.SendTo(data, serverPoint);          
                 
            }

            udpClient.Close();
            Console.ReadKey();
        }
    }
}
