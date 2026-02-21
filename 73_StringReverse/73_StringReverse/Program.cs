using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any name");
            string String = Convert.ToString(Console.ReadLine());

            string reverseString = " ";
            for (int i = String.Length - 1; i >= 0; i--)
            {
                reverseString += String[i];
            }
            Console.WriteLine(reverseString);
        }
    }
}
