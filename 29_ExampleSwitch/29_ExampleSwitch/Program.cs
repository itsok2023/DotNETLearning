using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_ExampleSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());

            switch (marks)
            {
                case 50:
                    Console.WriteLine("done");
                    break;
                case 100:
                    Console.WriteLine("excellent");
                    break;
                default:
                    Console.WriteLine("not done");
                    break;

            }
        }
    }
}
