using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ReadValueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondNumber = Convert.ToInt32(Console.Read());

            Console.WriteLine(firstNumber + secondNumber);
            Console.Read();

        }
    }
}
