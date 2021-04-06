using System;
using System.Collections.Generic;
using System.Text;

namespace CSort.Sort
{
    public class InsertionSort : Sort, Isort
    {
        public void Sort(int[] arr)
        {
            for(int i = 1; i<arr.Length; i++)
            {
                int value = arr[i];
                int j = i - 1;
                for(; j>=0; j--)
                {
                    if (arr[j] >= value)
                    {
                        arr[j + 1] = arr[j];
                    }
                    else
                        break;
                }
                arr[j + 1] = value;

                PrintArray(arr);
            }
        }
    }
}
