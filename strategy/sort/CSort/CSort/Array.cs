using System;
using System.Collections.Generic;
using System.Text;

namespace CSort
{
    public class Array
    {
        private int[] arr;
        private Isort sort;

        public void ApplySort(Isort sort)
        {
            this.sort = sort;
        }

        public Array(int [] arr)
        {
            this.arr = arr;
        }

        public void Sort()
        {
            if(sort==null)
            {
                Console.WriteLine($"还未分配排序方法， 不能进行排序！");
            }
            else
                sort.Sort(this.arr);
        }

    }
}
