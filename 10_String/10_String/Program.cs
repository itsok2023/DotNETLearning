using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "test";

            string firstName, email;
            firstName = "omkar";
            email = "omkar@gmail.com";

            firstName = "India";

            Console.WriteLine(name);
            Console.WriteLine(firstName);
            Console.WriteLine(email);
            Console.WriteLine(firstName + " " + email);

            Console.Read();
        }
    }
}
