using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_ProtectedAccessSpecifier
{
    public class ProtectedAccess
    {
        protected void Display()
        {
            Console.WriteLine("This is Protected Method");
        }
    }

    public class Print : ProtectedAccess
    {
        //Display()
        public void Show()
        {
            Display();
        }
    }

    public class Print2 : Print
    {
        //Display()
        public void Show2()
        {
            Display();
        }
    }

}
