//Number is ODD or EVEN

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OddEvenFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) 
            {
                Console.WriteLine("EVEN NUMBER");
            }
            else
            {
                Console.WriteLine("ODD NUMBER");
            }

            Console.ReadLine();
        }  

    }
}
