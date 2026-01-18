using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ElectionMaster
{
    internal class ClassPirvatePublic
    {
    }

    public class Outer
    {
        private class Inner
        {
            public void Show()
            {
                Console.WriteLine("Private Class inside the public");
            }
        }

        public class Inner2
        {
            Inner inner = new Inner();
            public void Manager()
            {
                inner.Show();
            }
            
        }

        public void Inter()
        {
            Inner2 inner2 = new Inner2();
            inner2.Manager();
        }

    }
}
