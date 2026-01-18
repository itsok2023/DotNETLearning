using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_MarksElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks");
            int marks = Convert.ToInt32(Console.ReadLine());

            if(marks < 50 || marks > 100)
            {
                Console.WriteLine("Enter marks between 50 to 100 / FAIL");
            }
            else if (marks > 90)
            {
                Console.WriteLine("A GRADE");
            }
            else if (marks > 70){
                Console.WriteLine("B GRADE");
            }
            else
            {
                Console.WriteLine("C GRADE");
            }


        }
    }
}
