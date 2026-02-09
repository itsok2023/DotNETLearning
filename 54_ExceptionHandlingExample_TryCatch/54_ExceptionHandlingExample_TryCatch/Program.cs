using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_ExceptionHandlingExample_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] cars = { "Maruti", "Alto", "Wagnor", "Nano", "Swift" };
                Console.WriteLine(cars[5]); // Index Out of Bound Exception
            }
            catch (IndexOutOfRangeException ex) // Specific Exception
            {
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine(ex.StackTrace.ToString());
                //Console.WriteLine(ex.InnerException.Message.ToString());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine(ex.StackTrace.ToString());
                //Console.WriteLine(ex.InnerException.Message.ToString());
            }
            catch (Exception ex) // Generic exception
            {
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine(ex.StackTrace.ToString());
                //Console.WriteLine(ex.InnerException.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Execute");
            }
            

            Console.Read();
            }
        }
    }
