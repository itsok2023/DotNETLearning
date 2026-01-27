using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_InheritanceExample
{
    // 
    public class BasePrinter
    {
        public void Print() 
        {
            Console.WriteLine("Paper Printer in Progress");
        }
    }

    public class PhotoPrinter: BasePrinter
    {
        public void PrintPhoto()
        {
            Console.WriteLine("Photo Printing");
        }

    }

    public class PaperPrinter : BasePrinter
    {
        public void PrintPaper()
        {
            Console.WriteLine("Paper Printing");
        }
    }
}
