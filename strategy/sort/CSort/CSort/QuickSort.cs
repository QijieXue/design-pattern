using System;
using System.Collections.Generic;
using System.Text;

namespace CSort
{
    public class QuickSort : Sort, Isort
    {
        public void Sort(int[] arr)
        {
            int left = 0; int right = arr.Length-1;
            quickSort(arr, left, right);

        }

        private void quickSort(int [] arr, int left, int right)
        {
            if (left >= right)
                return;
            //PrintArray(arr);

            int value = arr[left];
            int lPointer = left;
            int rPointer = right;
            while (lPointer < rPointer)
            {
                while (arr[rPointer] > value && lPointer < rPointer)
                    rPointer--;

                arr[lPointer] = arr[rPointer];
                while (arr[lPointer] < value && lPointer < rPointer)
                    lPointer++;
                arr[rPointer] = arr[lPointer];
            }
            arr[lPointer] = value;
            PrintArray(arr);

            quickSort(arr, left, lPointer - 1);
            quickSort(arr, lPointer + 1, right);

        }
    }
}
