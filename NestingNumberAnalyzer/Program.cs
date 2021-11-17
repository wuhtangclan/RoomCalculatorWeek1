using System;

namespace NestingNumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Please provide a number between 1 and 100.");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            if(num < 1 || num > 100)
            {
                Console.WriteLine("Please enter a positive number between 1 and 100.");
            }
            else if(num % 2 == 0)
            {
                if(num >= 2 && num <= 25)
                {
                    Console.WriteLine(name + ", you have entered an even number and less than 25.");
                } 
                else if(num >= 26 && num <= 60)
                {
                    Console.WriteLine(name + ", you have entered an even number.");
                }
                else
                {
                    Console.WriteLine(name + ", you have entered " + num + ", an even number.");
                }
            } 
            else
            {
                if(num > 60)
                {
                    Console.WriteLine(name + ", you have entered " + num + ", an odd number. ");
                }
                else
                {
                    Console.WriteLine(name + ", you have entered an odd number.");
                }
            }

            Console.WriteLine("Have a good day!");
        }
    }
}
