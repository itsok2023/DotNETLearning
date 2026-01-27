using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_EncapsulationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fridge fridge = new Fridge();
            Console.WriteLine(fridge.FridgeColdDrink(10));
            Console.WriteLine(fridge.FridgeVegetablePart("Potato"));
            Console.WriteLine(fridge.FridgeIceMakerPart(5));
            
            Console.Read();
        }
    }
}
