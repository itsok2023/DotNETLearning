using System;

namespace _76_StringStatementReversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the greet:");
            string greet = Console.ReadLine();

            string result = "";
            string word = "";

            // Step 1: Traverse string from last index to first
            for (int i = greet.Length - 1; i >= 0; i--)
            {
                if (greet[i] != ' ')
                {
                    // Step 2: Build word in reverse
                    word += greet[i];
                }
                else
                {
                    // Step 3: Add reversed word to result
                    result = word + " " + result;
                    word = ""; // reset word
                }
            }

            // Step 4: Add last word
            result = word + " " + result;

            Console.WriteLine("Reversed String: " + result.Trim());
            Console.Read();
        }
    }
}