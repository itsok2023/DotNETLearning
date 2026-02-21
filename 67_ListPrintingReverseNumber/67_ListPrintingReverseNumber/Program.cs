using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_ListPrintingReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number till want to print List : ");
            int end = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i <= end; i++)
            {
                list.Add(i);
            }

            //list.Reverse();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = end; i > 0; i--)
            {
                Console.WriteLine(list[i]);
            }


        }
    }
}
