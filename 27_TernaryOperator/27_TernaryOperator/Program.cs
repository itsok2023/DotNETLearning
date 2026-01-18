using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If else

            Console.WriteLine("Enter a marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 50)
                Console.WriteLine("Success by if else");
            else
                Console.WriteLine("Fail by if else");

            // Ternary


            Console.WriteLine((marks > 50) ? "Success by ternary" : "Fail by ternary");

            Console.Read();
        }
    }
}
