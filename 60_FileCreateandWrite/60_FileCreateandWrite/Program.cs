using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_FileCreateandWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\ok\name.txt";
            string des = @"C:\notok\name.txt";

            //string[] lines = { "Omkar", "Prathamesh", "Saurabh" };

            //File.AppendAllLines(path, lines);

            FileInfo info = new FileInfo(@"C:\ok\name.txt");
            Console.WriteLine(info.Length);

            File.Copy(info.FullName, des, true);
            File.Move
            Console.ReadLine();
        }
    }
}
