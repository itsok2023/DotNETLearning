using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumberUsingUserInput
{
    internal class Calculation
    {
        public void Add(int a , int b)
        {
            Console.WriteLine("Addition : " + (a + b));
        }

        public void Sub(int a , int b)
        {
            Console.WriteLine("Substraction : "+ (a - b));
        }

        public void Mult(int a, int b)
        {
            Console.WriteLine("Multiplication : "+ (a * b));
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine("Division : "+ (a / b));
        }
    }
}
