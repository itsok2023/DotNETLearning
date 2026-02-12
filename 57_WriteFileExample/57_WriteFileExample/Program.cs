using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _57_WriteFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (Directory.Exists(@"C:\Omkar3")) // Aready Exist check
            //    Console.WriteLine("Already Exist");
            //Directory.CreateDirectory(@"C:\Omkar3"); // Create a Folder

            //if (Directory.Exists(@"C:\Omkar"))
            //{
            //    Directory.Delete("C:\\Omkar"); // Delete the Directory
            //    Console.WriteLine("Directory Delete");
            //}
            //else
            //{
            //    Console.WriteLine("Not Delete Directory.. Directory does not exist");
            //}

            DirectoryInfo info =new DirectoryInfo("C:\\Omkar3");
            Console.WriteLine(info.Name);
            Console.WriteLine(info.LastAccessTime);
            

        }
    }
}
