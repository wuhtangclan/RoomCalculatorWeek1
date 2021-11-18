using System;

namespace LoopDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop with a break

            int i = 0;

            while(i <= 20)
            {
                Console.WriteLine(i);
                if (i == 10)
                {
                    Console.WriteLine("quitting early!");
                    break;
                }

                i++;
            }

            Console.WriteLine("all done!");
            Console.WriteLine("lets do it again");

            i = 0;

            while (true)
            {
                Console.WriteLine(i);
                if (i == 10)
                {
                    Console.WriteLine("getting out!");
                    break;
                }

                i++;
            }

            Console.WriteLine("all done!");

            //Console.WriteLine("maybe ths is better?");
            //bool keepGoing = true;
            //while (keepGoing == true)
            //{
            //    Console.WriteLine("We're going again!");
            //    Console.WriteLine(DateTime.Now);

            //    Console.WriteLine("Would you like to go again?");
            //    string entry = Console.ReadLine();
            //    if (entry == "N")
            //    {
            //        keepGoing = false;
            //    }
            //}

            Console.WriteLine("now we can ask the user whether to quit, but lets try another way.");
            string entry = "";
            do
            {
                Console.WriteLine("we're going again!");
                Console.WriteLine(DateTime.Now);

                Console.WriteLine("would you like to go again?");
                entry = Console.ReadLine();
            } while (entry != "N");

            Console.WriteLine("now lets try out 'continue'");

            for (int j =0; j <= 20; j++)
            {
                Console.WriteLine(j);
                if(j % 2 == 1)
                {
                    continue;
                }
                // at this point, j is even, so lets do the even stuff
                Console.WriteLine($"j is even. J times itself is {j * 2}");
            }

            Console.WriteLine("one more time but without continue");
            for (int j = 0; j <= 20; j++)
            {
                Console.WriteLine(j);
                if (j % 2 == 0)
                {
                    Console.WriteLine($"j is even. J times itself is {j * 2}");
                }
            }
        }
    }
}
