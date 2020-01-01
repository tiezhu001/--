using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class StrategyB:Strategy
    {
        public override double GetMoney(double money)
        {
            return money * 0.8;
        }
    }
}
