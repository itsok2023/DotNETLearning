using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64_StreamReaderExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamReader reader= new StreamReader("C:\\logFolder\\omkar.txt"))
            {
                //content = reader.Read();
                string content = string.Empty;
                while ((content = reader.ReadLine()) != null)
                {
                    Console.WriteLine(content);
                    
                }
            }
               
                Console.ReadLine();
        }
    }
}
