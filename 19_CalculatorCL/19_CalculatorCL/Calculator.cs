using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_CalculatorCL
{
    public static class Calculator
    {
        public static int Addition(int firstNumber, int secondNumber)
        {
            return (firstNumber + secondNumber); 
        }
        public static int Subtraction(int firstNumber, int secondNumber)
        {
            return (firstNumber - secondNumber);
        }
        public static int Multiplication(int firstNumber, int secondNumber)
        {
            return (firstNumber * secondNumber);
        }
        public static int Division(int firstNumber, int secondNumber)
        {
            return (firstNumber / secondNumber);
        }
    }
}
