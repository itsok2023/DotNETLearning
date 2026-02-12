using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _56_DividebyZeroException
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first Number : ");
                int firstNumber = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter second Number : ");
                int secondNumber = int.Parse(Console.ReadLine());
                int result = firstNumber / secondNumber;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ex)
            {
                // throw; Multiple throw keyword can write, but only one execute
                throw new Exception("Customize Exception message"); // new keyword is overriding
            }
            finally
            {
                
            }
            Console.Read();
        }
    }
}
