using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_NotificationUsingAbstractClass_UsingConstructor
{
    //Base Keyword
    public abstract class Notification
    {
        public Notification(string type)
        {
            Console.WriteLine(type);
        }
        public abstract void Notify();
    }

    public class Whatsapp: Notification
    {
        public Whatsapp(string type) : base(type)
        {

        }

        public override void Notify()
        {
            Console.WriteLine("Notification Send through WhatsApp");
        } 
    }
}

