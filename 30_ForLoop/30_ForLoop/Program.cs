using System;


namespace _30_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop Example : ");

            for (int value = 1; value <= 10; value++)
            {
                if (value == 7){
                    break;
                }
                Console.WriteLine(value);
            }

        }
    }
}
