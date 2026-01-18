using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_FunctionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print print = new Print();

            print.Show();
            print.Display();

            Console.Read();
        }
    }
}
