using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_StaticConstructorExample
{
    public static class Employee
    {
        // in static constructor only default constructor can be created
        // No parameterize constructor
        // No need of access  modifiers
        // Only call one time in static class
        static Employee()
        {
            Console.WriteLine("Default CTR");
        }

        public static void Message(string message) 
        {
            Console.WriteLine(message);
        }

    }
}
