using System;
using System.Collections.Generic;

namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {
            int drawerCount = DrawerCount();
            string woodType = WoodType();
            Console.WriteLine("Wood: {0}", woodType);
            Console.WriteLine("Drawers: {0}", drawerCount);
            Console.WriteLine("Total Price: {0}", woodCalculation(woodType, drawerCount));
        }
        static int DrawerCount()
        {
            Console.Write("Enter drawer count: ");
            int.TryParse(Console.ReadLine(), out int drawerCount);
            return drawerCount;
        }
        static string WoodType()
        {
            IDictionary<string, string> wood = new Dictionary<string, string>() { { "m", "mahogany" }, { "o", "oak" }, { "p", "pine" } };
            Console.Write("Enter wood type: ");
            wood.TryGetValue(Console.ReadLine().ToLower(), out string result);
            return result;
        }
        static int woodCalculation(string woodType, int drawerCount)
        {
            IDictionary<string, int> wood = new Dictionary<string, int>() { { "mahogany", 180 }, { "oak", 140 }, { "pine", 100 } };
            wood.TryGetValue(woodType, out int result);
            const int DRAWER_PRICE = 30;
            return (DRAWER_PRICE * drawerCount) + result;
        }
    }
}
