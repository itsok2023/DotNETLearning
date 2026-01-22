using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_ParameterizedConstructorExample
{
    internal class Addition
    {
        public Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Addition is : " + (firstNumber + secondNumber));
        }
    }
}
