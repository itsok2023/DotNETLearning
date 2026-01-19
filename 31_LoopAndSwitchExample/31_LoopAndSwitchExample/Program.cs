using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_LoopAndSwitchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch Case
            Console.WriteLine("Enter a number :");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                default:
                    Console.WriteLine("INVALID DAY");
                    break;
                case 1:
                    Console.WriteLine("Mon");
                    switch(Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("Morning");
                            break;
                        case 2:
                            Console.WriteLine("Afternoon");
                            break;
                        case 3:
                            Console.WriteLine("Evening");
                            break;
                        default:
                            Console.WriteLine("Night");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Tue");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thu");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;
            }
        }
    }
}
