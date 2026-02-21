using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_SortedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(30, "Aditya");
            dict.Add(5, "Omkar");
            dict.Add(25, "Sairaj");
            dict.Add(15, "Saurabh");

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value );
            }

            // Sorted Dictionary
            SortedDictionary<int, string> dict2 = new SortedDictionary<int, string>();
            dict2.Add(30, "Aditya");
            dict2.Add(5, "Omkar");
            dict2.Add(25, "Sairaj");
            dict2.Add(15, "Saurabh");

            foreach (var item in dict2)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            // Sorted List
            SortedList<int, string> dict3 = new SortedList<int, string>();
            dict3.Add(30, "Aditya");
            dict3.Add(5, "Omkar");
            dict3.Add(25, "Sairaj");
            dict3.Add(15, "Saurabh");

            foreach (var item in dict3)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
