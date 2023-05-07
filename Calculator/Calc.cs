using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public Calc()
        {

        }

        public double Compute(double firstNum, double secondNum, string op)
        {
            double result = 0;

            switch (op)
            {
                case "+":
                    result = Add(firstNum, secondNum);
                    break;
                case "-":
                    result = Subtract(firstNum, secondNum);
                    break;
                case "*":
                    result = Multiply(firstNum, secondNum);
                    break;
                case "/":
                    result = Divide(firstNum, secondNum);
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }

        public double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        public double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        public double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        public double Divide(double firstNum, double secondNum)
        {
            if (secondNum == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
            else
            {
                return firstNum / secondNum;
            }
        }
    }
}
