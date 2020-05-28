using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_直接插入排序
{
    class Program
    {
        static void InsertSort(int[] dataArry) //{ 42, 20, 17, 17, 13, 8, 17, 48 };
        {
            //for(int i = 1; i < dataArry.Length; i++)
            //{
            //    //int iValue = dataArry[i];        
            //    //bool isInsert = false;

            //    ////如果比i大，就让它向后移动
            //    //for(int j = i - 1; j >= 0; j--)     
            //    //{
            //    //    if (dataArry[j] > iValue)  //17      
            //    //    {
            //    //        dataArry[j + 1] = dataArry[j];
            //    //    }
            //    //    else
            //    //    {
            //    //        //发现一个比i小的值就不移动了             
            //    //        dataArry[j + 1] = iValue;
            //    //        isInsert = true;
            //    //        break;
            //    //    }
            //    //}
            //    //if (isInsert == false)
            //    //{
            //    //    dataArry[0] = iValue;     
            //    //}
            //}

            int i, j;
            for (i = 1; i < dataArry.Length; i++)
            {
                int temp = dataArry[i];
                for (j = i - 1; j >= 0 && temp < dataArry[j]; j--)
                {
                    dataArry[j + 1] = dataArry[j];
                }
                dataArry[j + 1] = temp;         //j--
            }


        }

        static void Main(string[] args)
        {
            int[] data = new int[] { 42, 20, 17, 17, 13, 8, 17, 48 };
            InsertSort(data);
            foreach(var temp in data)
            {
                Console.Write(temp + " ");
            }
            Console.ReadKey();
        }
    }
}
