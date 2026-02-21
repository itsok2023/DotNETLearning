using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71_StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NON GENERIC COLLECTION STACK
            Stack stack = new Stack();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            stack.Push("F");
            stack.Push("G");

            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }
            stack.Pop();
            
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }

            //  GENERIC COLLECTION STACK
            Stack<int> stack2 = new Stack<int>();
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Push(4);
            stack2.Push(5);
            stack2.Push(6);
            stack2.Push(7);

            foreach (var item in stack2)
            {
                Console.WriteLine(item.ToString());
            }
            stack.Pop();

            foreach (var item in stack2)
            {
                Console.WriteLine(item.ToString());
            }

                
        }
    }
}
