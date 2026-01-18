using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_UserLocked3Time
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //for (int i = 0; i < 3;) {

            //    Console.WriteLine("Enter UserName");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("Enter Password");
            //    string password = Console.ReadLine();

            //    if (username == "admin" && password == "admin@123")
            //    {
            //        Console.WriteLine("VALID USER!! Login Succesfully");
            //        break;
            //    }
            //    else
            //    {
            //        i++;
            //        if (i == 3)
            //        {
            //            Console.WriteLine("Please try after 24 Hours");
            //            break;
            //        }
            //        Console.WriteLine("Try Again");
            //    }


            //}


            int count = 0;

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Enter UserName");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                if (username != "admin" || password != "admin@123")
                {
                    Console.WriteLine("Try Again");
                    count++;


                    if(count == 3)
                    {
                        Console.WriteLine("PROFILE LOCKED!!! TRY AFTER 24 Hours");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Correct Username and Password");
                    i = 3;
                }


            }



        }
    }
}
