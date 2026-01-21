using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_WhileLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number  = 0;
            while (number < 5)
            {
                Console.WriteLine("Number is : " + number); 
                number++;
            }
            Console.ReadLine();
        }
    }
}
