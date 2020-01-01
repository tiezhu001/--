using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
   public class StrategyContext
    {
        private Strategy strategy = null;

        // 1.策略模式
        //public StrategyContext(Strategy strategySon)
        //{
        //    strategy = strategySon;
        //}

        // 2.策略模式与工厂结合
        public StrategyContext(string type)
        {
            switch (type)
            {
                case "1":
                    strategy = new StrategyA();
                    break;
                case "2":
                    strategy = new StrategyB();
                    break;
                case "3":
                    strategy = new StrategyC();
                    break;
            }
        }

        public double ContextInterface(double money)
        {
            return strategy.GetMoney(money);
        }


    }
}
