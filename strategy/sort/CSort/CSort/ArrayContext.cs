using System;
using CSort.Sort;

namespace CSort
{
    /// <summary>
    /// Context上下文类，将对象相关属性， 中间过程数据，日志记录等工作放到Context类中完成
    /// 面向接口编程，将算法的具体实现从类中剥离出去，使用包含关系调用算法接口
    /// </summary>
    public class ArrayContext
    {
        private int[] arrayData;
        private Isort sortingAlgorithm;

        public void ApplySort(Isort sort)
        {
            this.sortingAlgorithm = sort;
        }

        public ArrayContext(int [] arr)
        {
            this.arrayData = arr;
        }

        public void Sort()
        {
            if(sortingAlgorithm==null)
            {
                Console.WriteLine($"还未分配排序方法， 不能进行排序！");
            }
            else
                sortingAlgorithm.Sort(this.arrayData);
        }

    }
}
