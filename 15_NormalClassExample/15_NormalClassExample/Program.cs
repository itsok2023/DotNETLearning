using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NormalClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ClassName ObjectName = new ClassName()
            Employee employee = new Employee();

            Console.WriteLine(employee.Addition());
            Console.WriteLine(employee.Substraction());

            Console.ReadLine();

        }
    }
}
