using System;

namespace LoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before the loop");
            Console.WriteLine("getting ready!");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("let's count down starting with 10 and ending with 1 (inclusive for both)");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("all done!");
        }
    }
}
