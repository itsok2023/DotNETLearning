using System;
using System.IO;

namespace _59_MoveFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("C:\\MainF");
            Directory.CreateDirectory("C:\\SubF");

            Directory.Move(@"C:\SubF", @"C:\MainF\SubF");

            if (Directory.Exists(@"C:\MainF\SubF"))
            {
                Console.WriteLine("Folder Move Successfully");
            }
        }
    }
}
