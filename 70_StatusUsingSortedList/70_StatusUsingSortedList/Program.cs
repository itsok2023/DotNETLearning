using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_StatusUsingSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> status = new SortedList<string, string>();

            status.Add("R", "Rejected");
            status.Add("A", "Approved");
            status.Add("I", "Inprocess");

            foreach (var item in status)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
