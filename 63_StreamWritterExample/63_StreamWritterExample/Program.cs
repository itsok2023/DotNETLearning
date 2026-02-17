using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _63_StreamWritterExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 0;
            try
            {
                Console.WriteLine(firstNumber / secondNumber);
                Logger.Info("Program executed Successfully");
            }
            catch(Exception ex) 
            {
                Logger.Error(ex.Message);
            }

            Console.WriteLine("Content Written");
            Console.Read();

        }
    }
}
