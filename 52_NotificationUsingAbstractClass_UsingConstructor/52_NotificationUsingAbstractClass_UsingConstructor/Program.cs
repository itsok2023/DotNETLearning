using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_NotificationUsingAbstractClass_UsingConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Whatsapp whatsapp = new Whatsapp("Notification Done");
            whatsapp.Notify();
        }
    }
}
