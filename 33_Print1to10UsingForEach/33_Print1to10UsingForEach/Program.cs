using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Print1to10UsingForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            object[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var num in number)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(DateTime.Now);
        }
    }
}
