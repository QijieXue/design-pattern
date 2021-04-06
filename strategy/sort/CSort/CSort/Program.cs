using System;
using CSort.Sort;

namespace CSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Isort sortMethod = null;
            while(true)
            {
                int[] arrData = new int[] { 7, 6, 5, 4, 3, 2, 1, 4, 8, 9, 0 };


                Console.WriteLine("选择排序算法(1-冒泡； 2-快速):");
                string option = Console.ReadLine().Trim();
                int optionInteger = 0;
                if(int.TryParse(option, out optionInteger))
                {
                    sortMethod = SimpleSortFactory.CreateSortAlgorithm(option);

                    ArrayContext context = new ArrayContext(arrData);
                    context.ApplySort(sortMethod);
                    context.Sort();
                }
                else
                {
                    Console.WriteLine("非有效选项！");
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
