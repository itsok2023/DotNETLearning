using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_DoWhileLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                Console.WriteLine("Number is : " + number);
                number++;
            }
            while (number < 3);
        }
    }
}
