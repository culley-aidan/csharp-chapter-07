using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int.TryParse(Console.ReadLine(), out int multiplyInt);
            DisplayMultiplicationTable(multiplyInt);
        }
        static void DisplayMultiplicationTable(int number)
        {
            for (int i = 2; i < 11; ++i)
            {
                Console.WriteLine("{0}*{1}={2}", i, number, i * number);
            }
        }
    }
}
