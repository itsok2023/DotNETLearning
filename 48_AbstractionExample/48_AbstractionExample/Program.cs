using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_AbstractionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.EmpId(52);
            company.EmpName();
            Company company2 = new Company();
            company2.EmpId(52);
        }
    }
}
