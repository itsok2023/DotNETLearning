using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_HashtableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Saurabh");
            ht.Add(true, "Omkar");
            ht.Add(false, true);

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
