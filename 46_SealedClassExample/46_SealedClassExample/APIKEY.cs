using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_SealedClassExample
{
    // We can create object but not inheritance of Sealed Class
    public sealed class APIKEY
    {
        public void Key()
        {
            Console.WriteLine("8567-ADSDS"); 
        }
    }

    public class Money 
    {
        

    }

}
