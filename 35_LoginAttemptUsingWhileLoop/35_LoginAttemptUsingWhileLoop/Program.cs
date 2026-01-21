using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_LoginAttemptUsingWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "admin@123";
            int loginAttempt = 0;
            while(loginAttempt < 3)
            {
                Console.WriteLine("Enter Password : ");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Password CORRECT");
                    loginAttempt = 4;
                }
                Console.WriteLine("Incorrect Password !! TRY AGAIN");
                loginAttempt++;
            }
            if (loginAttempt == 3)
            {
                Console.WriteLine("Your Account Locked !! Open After 24 HOURS !!!");
            }


            
        }
    }
}
