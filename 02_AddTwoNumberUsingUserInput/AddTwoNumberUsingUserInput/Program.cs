using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumberUsingUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //int sum = firstNumber + secondNumber;
           Console.WriteLine("CALCULATION : ");
            Calculation obj = new Calculation();
            
            obj.Add(firstNumber, secondNumber);
            obj.Sub(firstNumber, secondNumber);
            obj.Mult(secondNumber, firstNumber);
            obj.Divide(firstNumber, secondNumber);
        }
    }
}
