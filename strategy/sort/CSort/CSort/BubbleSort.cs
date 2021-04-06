using System;
using System.Collections.Generic;
using System.Text;

namespace CSort
{
    /// <summary>
    /// 长度为7的数组
        //外层循环为6次
        //1 - 比较6次
        //2 - 比较5次
        //3 - 比较4次
        //4 - 比较3次
        //5 - 比较2次
        //6 - 比较1次

        //长度为n+1的数组
        //外层循环n次，一共比较n/2(a1+an)次
    /// </summary>
    public class BubbleSort : Sort, Isort
    {
        public void Sort(int[] arr)
        {
            PrintArray(arr);
            for(int i = 0; i<arr.Length-1; i++)
            {
                for(int j = 0; j<arr.Length-1-i; j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
                PrintArray(arr);
            }
        }
    }
}
