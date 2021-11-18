using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing == true)
            {
                Console.WriteLine("Hello! Please provide a positive integer number.");
                string input = Console.ReadLine();
                int num = int.Parse(input);

                if (num > 0)
                {
                    Console.WriteLine($"Number\tSquared\tCubed");
                    Console.WriteLine($"=======\t=======\t=======");
                    for (int i = 1; i <= num; i++)
                    {
                        //Console.WriteLine(i + "," + (i * i) + "," + (i * i * i));
                        Console.WriteLine($"{i}\t{i * i}\t{i * i * i}");
                    }

                    Console.WriteLine("Would you like to go again? (y or n)");
                    string entry = Console.ReadLine();
                    if (entry == "n")
                    {
                        keepGoing = false;
                    }
                }
                else
                {
                    Console.WriteLine("Input is not a positive integer.");
                }
            }

            Console.WriteLine("Good bye!");
        }
    }
}
