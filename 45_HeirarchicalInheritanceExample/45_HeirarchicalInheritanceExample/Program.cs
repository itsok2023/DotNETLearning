using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_HeirarchicalInheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Eat();
            cat.CatSound();
            Dog dog = new Dog();
            dog.Eat();
            dog.DogSound();
            Console.Read();
        }
    }
}
