using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_简单选择排序
{
    class Program
    {
        static void SelectSort(int[] dataArray)
        {
            for(int i = 0; i < dataArray.Length - 1; i++)
            {
                int min = dataArray[i];
                int minIndex = i;     // 

                for(int j = i + 1; j < dataArray.Length; j++)//选择最小元素
                {
                    if (dataArray[j] < min)
                    {
                        min = dataArray[j];
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = dataArray[i];
                    dataArray[i] = dataArray[minIndex];
                    dataArray[minIndex] = temp;
                }
                //foreach (var temp in dataArray)
                //{
                //    Console.Write(temp + " ");
                //}
                //Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] data = new int[] { 42, 20, 17, 22, 13, 8, 17, 46 };
            SelectSort(data);
            foreach(var temp in data)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
            
            //int min = data[0];
            //int minIndex = 0;
            //for (int j = 1; j < data.Length; j++)//选择最小元素算法
            //{
            //    if (data[j] < min)
            //    {
            //        min = data[j];
            //        minIndex = j;
            //    }
            //}
            //Console.WriteLine(min);             

            Console.ReadKey();
        }
    }
}
