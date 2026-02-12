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
        public static string Info(string info)
        {
            //Console.WriteLine(info);
            DateTime now = DateTime.Now;
            string infofile = now.ToString() + info;
            return infofile;
        
        }

        public static string Warn(string warn) 
        {
            //Console.WriteLine(warn);
            DateTime now = DateTime.Now;
            string warnfile = now.ToString() + warn;
            return warnfile;
        }

        public static string Error(string error)
        {
            //Console.WriteLine(error);
            DateTime now = DateTime.Now;
            string errorfile = now.ToString() + error;
            return errorfile;
        }

        public static void Divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Divide is " + (firstNumber / secondNumber));
        }
    }
}
