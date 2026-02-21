using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList developer = new ArrayList();
            developer.Add("Omkar");
            developer.Add("Aditya");

            foreach (object i in developer)
            {
                Console.WriteLine(i);
            }
        }
    }
}
