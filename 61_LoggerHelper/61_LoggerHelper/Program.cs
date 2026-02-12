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
            DateTime now = DateTime.Now;
            string date = now.ToString("dd-MM-yyyy");

            Console.WriteLine(date);

            string filename = date + "_logger.txt";

            try
            {
                Logger.Divide(5, 5);
                string info = Logger.Info(" Program Executed");
                Directory.CreateDirectory(@"C:\Logger");
                if (!(File.Exists(@"C:\Logger\" + filename)))
                {
                    File.WriteAllText(@"C:\Logger\" + filename, "INFO" + "\n");
                }
                File.AppendAllText(@"C:\Logger\" + filename, info + "\n");


            }
            catch(Exception e)
            {
                Directory.CreateDirectory(@"C:\Logger");
                if (!(File.Exists(@"C:\Logger\" + filename)))
                {
                    File.WriteAllText(@"C:\Logger\" + filename, "INFO" + "\n");
                }
                
                string error = Logger.Error(" ERROR : " + Convert.ToString(e.Message));
                string warn = Logger.Warn(" WARNING : " + Convert.ToString(e.StackTrace));

                File.AppendAllText(@"C:\Logger\" + filename, error + "\n");
                File.AppendAllText(@"C:\Logger\" + filename, warn + "\n");

            }

            Console.Read();
        }
    }
}
