using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    public class SubFunction : Operation
    {
        //public  double NumberA { get; set; }
        //public  double NumberB { get; set; }

        //public SubFunction(double numberA, double numberB) : base(numberA, numberB)
        //{
        //    NumberA = numberA;
        //    NumberB = numberB;
        //}

        public override double GetResult()
        {
            return Math.Abs(NumberA - NumberB);
        }
    }
}
