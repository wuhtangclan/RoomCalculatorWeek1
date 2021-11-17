using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter length of the classroom. ");  //getting user input for length
            string entry = Console.ReadLine();
            double length = double.Parse(entry);

            Console.WriteLine("Please enter the width of the classroom. ");  //getting user input for width
            entry = Console.ReadLine();
            double width = double.Parse(entry);

            Console.WriteLine("Please enter the height of the classroom. ");
            entry = Console.ReadLine();
            double height = double.Parse(entry);

            double area = length * width;
            Console.WriteLine("The area of the classroom is " + area + ".");

            double perimeter = (length * 2) + (width * 2);
            Console.WriteLine("The perimeter of the classroom is " + perimeter + ".");

            double volume = length * width * height;
            Console.WriteLine("The volume of the classroom is " + volume + ".");

            double surfaceArea = ((length * width) * 2) + ((length * height) * 2) + ((width * height) * 2);
            Console.WriteLine("The surface area of the classroom is " + surfaceArea + ".");

            if (area <= 250)
            {
                Console.WriteLine("The classroom is classified as small");
            } 
            else if (area >250 && area <= 650)
            {
                Console.WriteLine("The classroom is classified as medium");
            } 
            else
            {
                Console.WriteLine("The classroom is classified as large.");
            }

            Console.WriteLine("Have a good day!");







        }
    }
}
