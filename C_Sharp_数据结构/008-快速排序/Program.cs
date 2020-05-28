using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_快速排序
{
    class Program
    {
        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="dataArray"></param>
        /// <param name="left">开始的索引</param>
        /// <param name="right">结束的索引</param>
        static void QuickSort(int[] dataArray,int left,int right)
        {
            if (left < right)
            {
                int x = dataArray[left];//要排序的数组
                int i = left;//开始索引
                int j = right;//结束的索引

                while (true)
                {
                    if (dataArray[j] <= x)
                    {
                        dataArray[i] = dataArray[j];
                        break;
                    }
                    else
                    {
                        j--;                 //j=right
                    }
                }

                while(true && i < j)
                {
                    if (dataArray[i] > x)
                    {
                        dataArray[j] = dataArray[i];
                        break;
                    }
                    else
                    {
                        i++;                 //i=left
                    }
                }

                //跳出循环 现在i==j i是中间位置
                dataArray[i] = x;//left-i-right

                QuickSort(dataArray, left, i - 1);
                QuickSort(dataArray, i + 1, right);

            }
        }

        static void Main(string[] args)
        {
            int[] data = new int[] { 42, 20, 17, 23, 17, 8, 13, 46 };

            QuickSort(data, 0, data.Length - 1);

            foreach(var temp in data)
            {
                Console.Write(temp + " ");
            }

            Console.ReadKey();
        }
    }
}
