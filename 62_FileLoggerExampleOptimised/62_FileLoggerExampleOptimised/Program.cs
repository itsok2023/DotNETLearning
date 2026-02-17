using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _62_FileLoggerExampleOptimised
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.Information("Program Started");
            try
            {
                int number = 10;
                int divideNumber = 0;
                if (divideNumber == 0)
                {
                    Logger.Warning("The number is 0 may be you will get runtime Exception");
                }
                int result = number / divideNumber;
            }
            catch (Exception ex) 
            {
                Logger.Error(ex.Message + " " + ex.StackTrace);
            }
            Logger.Information("Program Ended");
        }
    }
}
