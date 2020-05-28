using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _003_tcpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //当我们创建tcpclient对象时，就会跟server建立连接
            TcpClient client = new TcpClient("192.222.60.176", 7788);

            NetworkStream stream = client.GetStream();//通过网络流进行数据的交换

            //read用来写入数据,Write用来写入数据，其实就是发送数据
            while(true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }            

            stream.Close();
            client.Close();
            Console.ReadKey();

        }
    }
}
