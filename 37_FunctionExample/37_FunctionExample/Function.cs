using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_FunctionExample
{
    public class Function
    {
        public void Onboarding()
        {
            Console.WriteLine("Employee Onboarding....");
        }

        public void EmlployeeName(string name)
        {
            Console.WriteLine("Employee Name : " + name);
        }

        public string GenerateEmployeeNumber()
        {
            // NON VOID + RETURN
            return "EMP" + new Random().Next(1000, 9999).ToString();
        }

        public string GenerateSalary(string empNumber) 
        {
            Console.WriteLine("Thanks for sharing Emp number: " + empNumber);
            Console.WriteLine("Will Start Finance Process here ");
            return "Salary generated for " + empNumber;
        }


    }
    
}
