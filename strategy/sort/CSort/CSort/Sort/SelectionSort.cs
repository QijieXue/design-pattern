using System;
using System.Collections.Generic;
using System.Text;

namespace CSort.Sort
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

    //长度为n的数组
    //外层循环n-1次，一共比较n*(n-1)/2次
    //最好情况，正序交换0次
    //最坏情况，逆序交互n-1次
    /// </summary>
    class SelectionSort : Sort, Isort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] <= arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int tmp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = tmp;
                }
                PrintArray(arr);
            }
        }
    }
}
