using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_PartialClassExample
{
    // Class no 1 :-
    public partial class ITR
    {
        public void GetAllDocument()
        {
            Console.WriteLine("All document received");
        }
    }

    // CLass no 2 :-
    public partial class ITR
    {
        public void VerifyDocument()
        {
            Console.WriteLine("All document Verified");
        }
    }

    // Class no 3 :-
    public partial class ITR
    {
        public void SendDocument()
        {
            Console.WriteLine("All document Send");
        }
    }


}
