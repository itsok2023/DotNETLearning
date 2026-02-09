using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _53_StaticArray
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Car = null;
            if (Car != null)
            {
                foreach (string cars in Car)
                    Console.WriteLine(cars);
            }else
            {
                Console.WriteLine("NULL VALUE");
            }
        }
    }
}
