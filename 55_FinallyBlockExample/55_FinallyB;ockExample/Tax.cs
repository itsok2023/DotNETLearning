using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_FinallyBlockExample
{
    public static class Tax
    {
        public static int GetTax()
        {
            int defaultTax = 12;
            try
            {
                return defaultTax;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return defaultTax;
            }
            finally
            {
                defaultTax = 30;
                Console.WriteLine("Finally Block Exexuted");
            }
            
        }
    }
}
