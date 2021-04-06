using System;
using System.Collections.Generic;
using System.Text;

namespace CSort.Sort
{
    public abstract class Sort
    {
        internal void PrintArray(int[] arr)
        {
            Console.WriteLine("当前数组序列为：");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
        }
    }
}
