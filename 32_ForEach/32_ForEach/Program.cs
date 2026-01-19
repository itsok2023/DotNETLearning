using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string status = "InProgress", "Approved", "Rejected";
            string[] AppStatus = { "InProgress", "Approved", "Rejected" }; // String Array
           
            
            
            //foreach (var item in AppStatus)
            //{

            //}
            foreach (string status in AppStatus)
            {
                Console.WriteLine("Application Status " + status);   
            }
        }
    }
}
