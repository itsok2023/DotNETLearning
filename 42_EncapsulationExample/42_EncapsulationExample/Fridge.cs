using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_EncapsulationExample
{
    public class Fridge
    {
        
        public int FridgeIceMakerPart(int iceCubeCount)
        {
            Console.WriteLine("Ice Cubes Available: ");
            return iceCubeCount;
        }
        public string FridgeVegetablePart(string vegetableName)
        {
            Console.WriteLine("Vagetable Name: ");
            return vegetableName;
        }
        public int FridgeColdDrink(int totalColdDrinks)
        {
            Console.WriteLine("Total Cold Drinks: ");
            return totalColdDrinks;
        }


    }
}
