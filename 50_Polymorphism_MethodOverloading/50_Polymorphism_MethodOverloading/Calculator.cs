using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Polymorphism_MethodOverloading
{
    //Without using Inheritance
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber; 
        }

        public int Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        public int Add(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            return firstNumber + secondNumber + thirdNumber + fourthNumber;
        }
    }
}
