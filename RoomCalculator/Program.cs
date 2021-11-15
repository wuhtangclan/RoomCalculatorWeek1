using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter length. ");  //getting user input for length
            string entryLength = Console.ReadLine();
            double length = double.Parse(entryLength);

            Console.WriteLine("Please enter width. ");  //getting user input for width
            string entryWidth = Console.ReadLine();
            double width = double.Parse(entryWidth);

            Console.WriteLine("Please enter height. ");
            string entryHeight = Console.ReadLine();
            double height = double.Parse(entryHeight);

            double area = length * width;
            Console.WriteLine("The area of the room is " + area + ".");

            double perimeter = (length * 2) + (width * 2);
            Console.WriteLine("The perimeter of the room is " + perimeter + ".");

            double volume = length * width * height;
            Console.WriteLine("The volume of the room is " + volume + ".");

            double surfaceArea = ((length * width) * 2) + ((length * height) * 2) + ((width * height) * 2);
            Console.WriteLine("The surface area of the room is " + surfaceArea + ".");




        }
    }
}
