using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_PartialClassExample
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ITR itr = new ITR();
            itr.GetAllDocument();
            itr.VerifyDocument();
            itr.SendDocument();
            
            itr.GetNonTaxAmount();
           

            NewReg newreg = new NewReg();
            newreg.NewFun();

            Console.Read();
        }
    }
}
