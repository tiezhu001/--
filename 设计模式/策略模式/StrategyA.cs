using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class StrategyA:Strategy
    {
        public override double GetMoney(double money)
        {
            return money;
        }
    }
}
