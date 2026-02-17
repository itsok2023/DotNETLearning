using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _61_LoggerHelper
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filename = Logger.LoggerTime();
            try
            {
                Logger.Divide(5, 0);
                string info = Logger.Info(" Program Executed");
                File.AppendAllText(@"C:\Logger\" + filename, info + Environment.NewLine);
            }
            catch(Exception e)
            {
                
                string error = Logger.Error(" ERROR : " + Convert.ToString(e.Message));
                string warn = Logger.Warn(" WARNING : " + Convert.ToString(e.StackTrace));

                File.AppendAllText(@"C:\Logger\" + filename, error + Environment.NewLine);
                File.AppendAllText(@"C:\Logger\" + filename, warn + Environment.NewLine);

            }

            Console.Read();
        }
    }
}
