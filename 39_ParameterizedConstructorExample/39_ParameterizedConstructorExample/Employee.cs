using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_ParameterizedConstructorExample
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor");
        }
        public Employee(int id)
        {
            Console.WriteLine("ID : " + id);
        }
        public Employee(string name)
        {
            Console.WriteLine("Name : " + name);
        }
        
    }
}
