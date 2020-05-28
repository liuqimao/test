using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    interface IStackDS<T>      
    {
        /// <summary>
        /// 链表的接口
        /// </summary>
        int Count { get; }
        int GetLength();
        bool IsEmpty();
        void Clear();
        void Push(T item);
        T Pop();
        T Peek();

    }
}
