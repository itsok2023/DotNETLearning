using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_MultilevelInheritance
{
    //We use 90% single level inheritance
    public class Principal
    {
        public Principal() 
        {
            Console.WriteLine("Principle Constructor");
        }
        //public void CollegeInfo()
        //{
        //    Console.WriteLine("College Name = IIT");
        //}
    }

    public class Teacher:Principal
    {
       public Teacher()
        {
            Console.WriteLine("ABC");
        }
    }

    public class Student:Teacher
    {
        public Student()
        {
            Console.WriteLine("ID = STUID");
        }
    }
}
