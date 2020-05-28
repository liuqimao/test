using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    class SeqStack<T> : IStackDS<T>
    {
        /// <summary>
        /// 顺序栈
        /// </summary>
        private T[] data;        //数组 
        private int top;

        public SeqStack(int size)//构造函数
        {
            data = new T[size];
            top = -1;
        }

        public SeqStack():this(10)//默认构造函数
        {
        }

        public int Count          //元素个数
        {
            get { return top + 1; }
        }
         
        public void Clear()       //清空栈元素
        {
            top = -1;
        }

        public int GetLength()    //长度
        {
            return Count;
        }

        public bool IsEmpty()     //是否为空
        {
            return Count == 0;
        }

        public T Peek()           //栈顶元素
        {
            
            return data[top];
        }

        public T Pop()            //出栈
        {
            T temp = data[top];
            top--;
            return temp;
        }

        public void Push(T item)  //入栈
        {
            data[top + 1] = item;
            top++;
        }
    }
}
