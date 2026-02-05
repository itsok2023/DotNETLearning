using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Polymorphism_MethodOverriding
{
    //Base class reference object creation
    public class Calculator1
    {
        public virtual int Operation(int x, int y)
        {
            Console.WriteLine("Addition");
            return x + y; 
        }
    }

    public class Calculator2: Calculator1
    {
        public override int Operation(int x, int y)
        {
            
                Console.WriteLine("Subtraction");
                return x - y;
            
        }
    }

    public class Calculator3: Calculator2
    {
        public override int Operation(int x, int y)
        {
            Console.WriteLine("Multiplication");
            return x * y;
            
        }
    }

    public class Calculator4: Calculator3
    {
        public override int Operation(int x, int y)
        {
            Console.WriteLine("Divide");
                return x / y;
            
        }
    }
}
