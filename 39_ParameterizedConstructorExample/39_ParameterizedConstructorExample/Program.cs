using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_ParameterizedConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition(5,6);
            
            Console.Read();
        }
    }
}
