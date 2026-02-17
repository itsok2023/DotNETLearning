using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _62_FileLoggerExampleOptimised
{
    public static class Logger
    {
        public static void Information(string message)
        {
            LogWritter("INFO : ", message);
        }
        public static void Warning(string message)
        {
            LogWritter("WARN : ", message);
        }
        public static void Error(string message)
        {
            LogWritter("ERROR : ", message);
        }
        public static void LogWritter(string type, string message)
        {
            Directory.CreateDirectory("C://LogFolder");
            DateTime now = DateTime.Now;
            string filename = now.ToString("dd-MM-yyyy");
            File.AppendAllText("C:\\LogFolder\\" + filename + "logger.txt", type + now.ToString() + message + Environment.NewLine);
        }
    }
}
