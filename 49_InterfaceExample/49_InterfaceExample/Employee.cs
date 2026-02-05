using _49_InterfaceExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_InterfaceExample
{
    public class Employee: IEmployee, IBaseEmployee
    {
        public void Show()
        {
            Console.WriteLine("IEmployee Show Method");
        }
    }

    public class Manager : IBaseEmployee, IEmployee
    {
        public void Show()
        {
            Console.WriteLine("IBaseEmployee Show Method");
        }
    }
   
}
