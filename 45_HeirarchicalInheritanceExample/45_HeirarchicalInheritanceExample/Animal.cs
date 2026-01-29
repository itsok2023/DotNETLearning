using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_HeirarchicalInheritanceExample
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("I am Eating Food");
        }
    }

    public class Cat:Animal
    {
        public void CatSound()
        {
            Console.WriteLine("Cat Sound");
        }
    }

    public class Dog:Animal
    {
        public void DogSound()
        {
            Console.WriteLine("Dog Sound");
        }
    }

}
