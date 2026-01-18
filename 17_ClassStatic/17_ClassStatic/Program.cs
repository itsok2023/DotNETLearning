using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ClassStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.Addition(); // Default Function - Without Parameter Without Return Type
            Calculator.Subtaction();
            Console.WriteLine(Calculator.Multiplication()); // Without Parameter With Return Type
            Console.WriteLine(Calculator.Division(50,50)); // With Parameter With Return Type

            Console.Read();
        }
    }
}
