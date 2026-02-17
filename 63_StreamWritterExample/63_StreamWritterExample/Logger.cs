using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_StreamWritterExample
{
    static class Logger
    {
        public static void  Info(string message)
        {
            Append("INFO" + message);
        }
        public static void Warn(string message)
        {
            Append("WARN" + message);
        }
        public static void Error(string message)
        {
            Append("ERROR" + message);
        }
        public static void Append(string filemessage)
        {
            string filename = "C://LogFolder//" +  System.DateTime.UtcNow.ToString("dd-MM-yyyy") + "omkar.txt";
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(System.DateTime.UtcNow.ToString("dd-MM-yyyy") + filemessage);
            }
        }


    }
}
