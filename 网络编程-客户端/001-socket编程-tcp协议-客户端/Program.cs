﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _001_socket编程_tcp协议_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1、创建socket
            //Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ////2、绑定IP跟端口号 192.168.0.112
            //IPAddress iPAddress = new IPAddress(new byte[] { 192, 168, 0, 112 });
            //EndPoint point = new IPEndPoint(iPAddress,77888);  //ipendpoint是对 ip+端口 做了一层封装的类
            //tcpServer.Bind(point);                             //向操作系统申请一个可用的IP跟端口号，用来做通信

            ////3、开始监听（等待客户端连接）
            //tcpServer.Listen(100); //参数是最大连接数
            //Socket clientSocket = tcpServer.Accept();          //暂停当前线程，直到有一个客户端连接过来，之后进行下面的代码

            ////使用返回的socket跟客户端做通信
            //string message = "hello 欢迎你!";
            //byte[] data = Encoding.UTF8.GetBytes(message); //对字符串做编码，得到一个字符串的字节数组
            //clientSocket.Send(data);

            //1、创建socket
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //2、发起建立连接的请求
            IPAddress ipaddress = IPAddress.Parse("192.222.60.176");  //可以把一个字符串的IP地址转化成一个ipaddress的对象

            EndPoint point = new IPEndPoint(ipaddress,7788);        
            tcpClient.Connect(point);                                 //通过IP：端口号 定位一个要连接到的服务器端

            byte[] data = new byte[1024];
            int length=tcpClient.Receive(data);                       //这里传递接收一个byte数组，实际上这个data数组用来接收数据
            //length返回值表示接收了多少字节的数据

            string message = Encoding.UTF8.GetString(data, 0, length);//只把接收到的数据做一个转化
            Console.WriteLine(message);

            //向服务器端发送消息
            string message2 = Console.ReadLine();                     //读取用户的输入 把输入发送到服务器端
            tcpClient.Send(Encoding.UTF8.GetBytes(message2));         //把字符串转化成字节数组，然后发送到服务器端

            Console.ReadKey();
        }
    }
}
