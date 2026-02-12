using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _58_SubDirectoryAccessName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists(@"C:\MainFolder"))
                Console.WriteLine("MainFolder Created");
            Directory.CreateDirectory(@"C:\MainFolder");

            string[] mainfolder = Directory.GetDirectories("C:\\MainFolder");

            for (int i = 1; i <= 10; i++)
            {
                    Directory.CreateDirectory(@"C:\MainFolder\SubFolder" + i);
            }
            foreach (string sub in mainfolder)
            {
                Console.WriteLine(sub);
            }
            Console.WriteLine("This is FOlder Count :" + mainfolder.Length);

            

        }
    }
}
