using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Level Inheritance Example
            
            PaperPrinter paperprinter = new PaperPrinter();
            paperprinter.PrintPaper();
            paperprinter.Print();
            Console.ReadLine();
            
        }
    }
}
