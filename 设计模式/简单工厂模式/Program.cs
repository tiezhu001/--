using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {


        /// <summary>
        /// 实现一个计算器程序-计算 + - * /
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // 1.根据输入的符号实例化一个计算器类
            Console.WriteLine("请输入一个符号");
            Operation operation = null;
            string s = Console.ReadLine();
            try
            {
                 operation = OperationFactory.CreateOperation(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            if (operation != null)
            {
                operation.NumberA = 10;
                operation.NumberB = 20;
                var result = operation.GetResult();
                Console.WriteLine("{0}", result);
            }

            Console.ReadKey();
        }
    }
}
