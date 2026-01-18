using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_PartialClassExample
{
    public class NewReg
    {
        ITR itr = new ITR();


        public void NewFun()
        {
         
            itr.VerifyDocument();
        }
        
        

    }



    public partial class ITR
    {
        ITR itr = new ITR();
        public void GetNonTaxAmount()
        {
           

            itr.VerifyDocument();
            Console.WriteLine("Non Tax Document");
        }


    }
  
}
