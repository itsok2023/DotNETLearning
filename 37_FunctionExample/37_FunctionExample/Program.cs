using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_FunctionExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Function function = new Function();

            // VOID - NON PARAMETERIZE
            function.Onboarding();

            // VOID - PARAMETERIZED
            function.EmlployeeName("Omkar");

            // NON VOID - NON PARAMETERIZE
            string empnumber =  function.GenerateEmployeeNumber();
            Console.WriteLine(empnumber);

            // NON VOID - PARAMETERIZE
            string salary = function.GenerateSalary(empnumber);
            Console.WriteLine(salary);

            
        }
    }
}
