using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_ListCollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Ruturaj");
            names.Add("Sairaj");
            names.Add("Omkar");
            names.Add("Keshav");
          
            names[3] = "KeshavBoy";
            Console.WriteLine("Total Elements of Collection : " + names.Count);

            //if (names.Count>0)
            //{
            //    foreach (string name in names)
            //    {
            //        Console.WriteLine(name);
            //    }

            //}
            Console.WriteLine(names[3]);
           

        }
    }
}
