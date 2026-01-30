using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_AbstractionExample
{
    public abstract class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Consturtor in Abstract Class");
        }

        public abstract void EmpId(int id);

        public void EmpName()
        {
            Console.WriteLine("Emploee Name = Omkar");
        }
        
    }

    public class Company: Employee
    {
        public override void EmpId(int id)
        {
            Console.WriteLine("EmpID = " + id );
        }

    }
}
