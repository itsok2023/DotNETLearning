using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ClassStatic
{
    public static class Calculator
    {
        public static void Addition()
        {
            Console.WriteLine("50 + 50 =" + (50 + 50));
        }

        public static void Subtaction()
        {
            Console.WriteLine("50 - 50 = 0" + (50 - 50));
        }

        public static int Multiplication()
        {
            return (50 * 50);
        }

        public static int Division(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Division of 2 numbers : ");

            Console.WriteLine("Division of " + firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber));
            return 0;
        }
    }
}
