using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_InterfaceExample
{
    // Interface - Always public
    public interface IEmployee
    {
        void Show();
    }

    public interface IBaseEmployee : IEmployee
    {
        void Show();
       
    }

}
