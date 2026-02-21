using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_DictionaryExample_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> emp = new Dictionary<int, string>();
            emp.Add(1, "Sairaj");
            emp.Add(4, "omkar");
            emp.Add(12, "Aditay");
            emp.Add(16, "Prathamesh");

            foreach (var item in emp) 
            {
                //Console.WriteLine(item);
                Console.WriteLine(item.Key + " : " +  item.Value);

            }
        }
    }
}
