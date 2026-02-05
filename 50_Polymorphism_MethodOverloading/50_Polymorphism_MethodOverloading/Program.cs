using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Polymorphism_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Addition is = " + calculator.Add(5, 5));
            Console.WriteLine("Addition is = " + calculator.Add(5, 5, 10));
            Console.WriteLine("Addition is = " + calculator.Add(5, 5, 50, 42));
        }
    }
}
