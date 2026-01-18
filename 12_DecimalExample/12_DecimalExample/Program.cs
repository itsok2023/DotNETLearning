using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_DecimalExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Float Data Type
            Console.WriteLine("Float Data Type");
            float price = 45.611111111111111555555555555f;
            Console.WriteLine(price);

            // Decimal Data Type
            Console.WriteLine("Decimal Data Type");
            decimal amount = 45.77777777777777777777777777777777777777777777777777777777777777777777777777m;
            Console.WriteLine(amount);

            float price2 = (float) amount;
            decimal amount2 = (decimal) price;

            Console.Read();
        }
    }
}
