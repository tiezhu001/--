using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class OperationFactory
    {
        public static Operation CreateOperation(string operationSimple)
        {
            Operation operation = null;
            switch (operationSimple)
            {
                case "+":
                    operation = new AddFunction();
                    break;
                case "-":
                    operation = new SubFunction();
                    break;
                default:
                    throw new ArgumentException("输入的符号有错误");
            }

            return operation;
        }
    }
}
