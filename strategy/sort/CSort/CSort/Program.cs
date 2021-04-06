using System;

namespace CSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] arr= new int[] { 7, 6, 5, 4, 3, 2, 1 };
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Array array = new Array(arr);
            array.ApplySort(new QuickSort());
            array.Sort();
            Console.ReadLine();
        }
    }
}
