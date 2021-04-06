using System;
using System.Collections.Generic;
using System.Text;

namespace CSort.Sort
{
    /// <summary>
    /// 算法接口
    /// 所有算法的具体实现都继承自本接口
    /// </summary>
    public interface Isort
    {
        void Sort(int [] arr);

    }
}
