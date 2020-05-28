using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_栈和队列的应用
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();//栈：后进先出
            Queue<char> queue = new Queue<char>();//队列：先进先出

            for(int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);    //入栈
                queue.Enqueue(str[i]); //入队
                
            }

            bool isHui = true;
            while (stack.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    isHui = false;
                    break;
                }
            }
            Console.WriteLine("是否是回文字符串：" + isHui);
            Console.ReadKey();
        }
    }
}
