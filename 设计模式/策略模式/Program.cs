using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class Program
    {
        /// <summary>
        /// 如果一个对象有很多中行为，而且行为上只有细微的差别，就可以使用策略模式来处理这个对象的行为
        /// 补充:我觉得策略模式和简单工厂有点类似
        /// 本例子主要实现了商场简单的不同收费方式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 1.纯粹的策略模式

            //StrategyContext context = null;
            //double money = 200;
            //Console.WriteLine("选择一个销售方式");
            //string s = Console.ReadLine();

            //switch (s)
            //{
            //    case "1":
            //        context = new StrategyContext(new StrategyA());
            //        break;
            //    case "2":
            //        context = new StrategyContext(new StrategyB());
            //        break;
            //    case "3":
            //        context = new StrategyContext(new StrategyC());
            //        break;
            //}

            //Console.WriteLine(context.ContextInterface(money));
            //Console.ReadKey();

            #endregion

            #region 2.策略模式加简单工厂

            StrategyContext context = null;
            double money = 200;

            context = new StrategyContext("2");
           Console.WriteLine(context.ContextInterface(money));
           Console.ReadKey();

           #endregion

        }
    }
}
