using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19_CalculatorCL;

namespace _20_CLExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Addition(25, 30));
            Console.WriteLine(Calculator.Multiplication(25, 30));
            Console.WriteLine(Calculator.Subtraction(25, 30));
            Console.WriteLine(Calculator.Division(25, 30));

            Console.ReadLine();
        }
    }
}
