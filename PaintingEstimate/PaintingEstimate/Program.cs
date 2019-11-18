using System;

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the room: ");
            double.TryParse(Console.ReadLine(), out double roomLength);
            Console.Write("Enter the width of the room: ");
            double.TryParse(Console.ReadLine(), out double roomWidth);
            const double HEIGHT = 9;
            const double PRICE = 6;
            Console.WriteLine("The total cost of the room is {0:C}.", Price(Volume(roomLength, roomWidth, HEIGHT), PRICE));
        }

        static double Volume(double length, double width, double height)
        {
            return length * height * width;
        }
        static double Price(double sqft, double price)
        {
            return sqft * price;
        }
    }
}
