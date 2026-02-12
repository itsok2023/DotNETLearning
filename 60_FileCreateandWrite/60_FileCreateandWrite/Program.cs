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
            // Copy File
            Directory.CreateDirectory(@"C:\ok");
            Directory.CreateDirectory(@"C:\notok");
            string path = @"C:\ok\a.txt";
            File.WriteAllText(path, "Hello World");
            File.Copy(path, @"C:\notok\a.txt", true);

            // Move File
            File.WriteAllText(@"C:\ok\b.txt", "Moving File");
            File.Move(@"C:\ok\b.txt", @"C:\notok\b.txt");


            //Append Lines
            File.WriteAllText(@"C:\ok\c.txt", "File for Append");
            string[] names = { "OK", "NOTOK", "ALWAYSOK" };
            File.AppendAllLines(@"C:\ok\c.txt", names);

            //Size of file
            FileInfo cfile = new FileInfo(@"C:\ok\c.txt");
            Console.WriteLine(cfile.Length + " bytes");

            Console.Read();
        }
    }
}
