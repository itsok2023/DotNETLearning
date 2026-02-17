using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _61_LoggerHelper
{
    public static class Logger
    {
        public static DateTime now = DateTime.Now;
        public static string LoggerTime()
        {
            string date = now.ToString("dd-MM-yyyy");

            string filename = date + "_logger.txt";
            Directory.CreateDirectory(@"C:\Logger");

            if (!(File.Exists(@"C:\Logger\" + filename)))
            {
                File.WriteAllText(@"C:\Logger\" + filename, "INFO" + "\n");
            }
            return filename;
        }

        public static void WriteLog(string )
        {

        }

        public static string Info(string info)
        {
            
            string infofile = now.ToString() + info;
            return infofile;
        
        }

        public static string Warn(string warn) 
        {
            string warnfile = now.ToString() + warn;
            return warnfile;
        }

        public static string Error(string error)
        {
            string errorfile = now.ToString() + error;
            return errorfile;
        }

        public static void Divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Divide is " + (firstNumber / secondNumber));
        }
    }
}
