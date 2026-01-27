using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_CopyConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PARAMETERIZED CTOR
            Print print1 = new Print(1, "Omkar");
            Console.WriteLine("Print1 Id: {0}, Name: {1}", print1.Id, print1.Name);

            // COPY CTOR
            Print print2 = new Print(print1);
            Console.WriteLine("Print2 Id: {0}, Name: {1}", print2.Id, print2.Name);
        }
    }
}
