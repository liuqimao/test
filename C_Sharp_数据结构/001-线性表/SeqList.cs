using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    class SeqList<T> : IListDS<T>
    {
        /// <summary>
        /// 顺序表实现方式
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>

        private T[] data;//储存数据
        private int count = 0;//表示储存数据的个数

        public SeqList(int size)//
        {
            data = new T[size];
            count = 0;
        }

        public SeqList() : this(10)//默认构造函数 容量是10
        {

        }

        public T this[int index]
        {
            get { return GetEle(index); }
        }

        public void Add(T item)
        {
            if(count==data.Length)//当前数组已经存满
            {
                Console.WriteLine("当前顺序表已经次存满！");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        public void Clear()//清空列表
        {
            count = 0;
        }

        public T Delete(int index)//删除元素
        {
            T temp = data[index];
            for(int i=index+1;i<count;i++)
            {
                data[i - 1] = data[i];//把数据向前移动
            }
            count--;
            return temp;
        }

        public T GetEle(int index)
        {
            if (index >= 0 && index <= count - 1)//索引存在
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);
            }
        }

        public int GetLength()//获取列表长度
        {
            return count;
        }

        public void Insert(T item, int index)//插入元素
        {
            for(int i=count-1;i>=index;i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        public bool IsEmpty()//判断列表是否为空
        {
            return count == 0;
        }

        public int Locate(T value)
        {
             for(int i=0;i<count;i++)
            {
                if(data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
