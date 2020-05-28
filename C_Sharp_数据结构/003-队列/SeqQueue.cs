using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_队列
{
    class SeqQueue<T> : IQueue<T>//继承接口
    {
        private T[] data;//数组
        private int count;//元素个数
        private int front;//
        private int rear;

        public SeqQueue(int size)
        {
            data = new T[size];
            count = 0;
            front = -1;
            rear = -1;
        }

        public SeqQueue():this(10)
        {
        }

        public int Count
        {
            get { return count; }
        }

        public void Clear()
        {
            count = 0;
            front = rear=-1;
        }

        public T Dequeue() //出队
        {
            if (count >0)
            {
                T temp = data[front + 1];
                front++;
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空，无法取得队首数据。");
                return default(T);
            }
        }

        public void Enqueue(T item)             //入队
        {
             if(count==data.Length)
            {
                Console.WriteLine("队列已满，不可以再添加新的数据");
            }
            else
            {
                if(rear==data.Length-1)
                {
                    data[0]=item;
                    rear = 0;
                    count++;                    
                }
                else
                {
                    data[rear + 1] = item;
                    rear++;
                    count++;
                }
            }
        }

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            T temp = data[front + 1];
            return temp;
        }
    }
}
