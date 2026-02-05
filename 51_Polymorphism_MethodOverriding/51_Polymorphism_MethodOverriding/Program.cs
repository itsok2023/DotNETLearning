using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Polymorphism_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Base class Reference

            Calculator1 multiply = new Calculator3();
            Console.WriteLine(multiply.Operation(6, 6));

            Calculator1 subtract = new Calculator2();
            Console.WriteLine(subtract.Operation(6, 6));

            Calculator1 divide = new Calculator4();
            Console.WriteLine(divide.Operation(6, 6));
        }
    }
}
