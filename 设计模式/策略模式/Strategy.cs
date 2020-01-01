using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 策略类
    /// </summary>
   public abstract class Strategy
    {
        public abstract double GetMoney(double money);
    }
}
