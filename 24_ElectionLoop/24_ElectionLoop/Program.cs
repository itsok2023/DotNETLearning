using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_ElectionLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18 || age >119)
            {
                Console.WriteLine("NOT VALID for Voting");
            }
            else
            {
                Console.WriteLine("VALID for Voting");
            }


            Console.Read();
        }

        
        
    }
}
