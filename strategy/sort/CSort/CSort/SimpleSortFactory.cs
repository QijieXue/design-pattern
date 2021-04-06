using System;
using CSort.Sort;
using System.Reflection;
using System.Reflection.Emit;
using System.Configuration;

namespace CSort
{
    public class SimpleSortFactory
    {
        /// <summary>
        /// 使用简单工厂模式来创建算法实例
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public static Isort CreateSortAlgorithm(string option)
        {
            Isort sortMethod = null;

            ///使用配置文件+反射， 动态创建排序算法类型
            var packageName = ConfigurationManager.AppSettings[option].Split(",")[0];
            var typeName = ConfigurationManager.AppSettings[option].Split(",")[1];

            Assembly assembly = Assembly.LoadFrom(packageName);
            Type type = assembly.GetType(typeName);
            sortMethod = (Isort)Activator.CreateInstance(type);

            return sortMethod;
        }
    }
}
