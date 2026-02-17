using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _65_StreamWriter_And_StreamReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Omkar\\";
            Directory.CreateDirectory(path);

            using (StreamWriter sw = new StreamWriter(path + "omkar.txt")) 
            {
                sw.WriteLine("Hello Team");
                sw.WriteLine("Good Day");
                sw.WriteLine("My name is Omkar");
            }

            using (StreamReader reader = new StreamReader(path + "omkar.txt"))
            {
               string content;

               while((content = reader.ReadLine()) != null)
               {
                    Console.WriteLine(content);
               }
               
            }
        }
    }
}
