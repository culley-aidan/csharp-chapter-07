using System;

namespace ConvertQuartsToLiters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of quarts: ");
            double.TryParse(Console.ReadLine(), out double quarts);
            Console.WriteLine("{0} quarts is {1} liters.", quarts, Liters(quarts));
        }
        static double Liters (double quarts)
        {
            return quarts * .966353D;
        }
    }
}
