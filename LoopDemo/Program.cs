using System;

namespace LoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 10;
            Console.WriteLine(q);
            q++; // idenitcal to q =q + 1
            q += 5; // same as q = q+5
            Console.WriteLine(q);



            Console.WriteLine("Before the loop");
            Console.WriteLine("getting ready!");

            for (int i = 0; i <= 10; i++) //most common for loop
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("let's count down starting with 10 and ending with 1 (inclusive for both)");
            for (int i = 10; i >= 1; i--)
            {
                //int r = 5;   Does it go away? What is its scopre?
                Console.WriteLine(i);
                //Console.WriteLine(r);
            }

            Console.WriteLine("lets count by 2's.");
            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("lets do a while loop");
            int j = 0; //have to make this variable before
            while (j <= 20)
            {
                Console.WriteLine(j);
                //j += 2;  //have to manually add this
                if(j < 10)
                {
                    j++;
                }
                else
                {
                    j += 2;
                }
            }
            Console.WriteLine("done with while loop!");
            Console.WriteLine($"the j varaible is now {j}");

            Console.WriteLine("Lets do another while loop");
            j = 0;
            while (j > 0)
            {
                Console.WriteLine(j);  // will not run
                j++;
            }


            Console.WriteLine("lets do a do-while loop");
            j = 0;
            do
            {
                Console.WriteLine(j);
                j += 2;
            } while (j <= 20);

            Console.WriteLine("another do-while loop");  // will run. do-while always runs at least once. 
            j = 0;
            do
            {
                Console.WriteLine(j);
                j += 2;
            } while (j < 0);


            Console.WriteLine("all done!");
        }
    }
}
