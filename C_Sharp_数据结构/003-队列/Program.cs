using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_队列
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.使用BCL的队列
            //Queue<int> queue = new Queue<int>();
            //2.使用我们的顺序队列
            //IQueue<int> queue = new SeqQueue<int>();
            //3.使用我们的链队列
            IQueue<int> queue = new LinkQueue<int>();



            //入队
            queue.Enqueue(23);//添加数据
            queue.Enqueue(33);
            queue.Enqueue(43);
            queue.Enqueue(32);
            queue.Enqueue(55);
            queue.Enqueue(77);
            Console.WriteLine("添加了23，33,43,32,55,77之后队列的大小：" + queue.Count);
            
            //出队
            int i = queue.Dequeue();//获取对首，并删除
            Console.WriteLine("取得队首的数据为：" + i);
            Console.WriteLine("出队之后，队列的大小为：" + queue.Count);
            int j = queue.Peek();
            Console.WriteLine("Peek得到的结果是：" + j);
            Console.WriteLine("Peek之后队列的大小为:" + queue.Count);
            queue.Clear();

            Console.WriteLine("clear 之后队列的大小为：" + queue.Count);
            Console.ReadKey();


        }
    }
}
