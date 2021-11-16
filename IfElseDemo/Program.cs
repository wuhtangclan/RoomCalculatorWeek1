using System;

namespace IfElseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // some basic comparisons i.e less than, less than or equal, greater than, greater than or equal, equal, not equal

            int x = 10;
            int y = 5;

            //if (x > y)
            //{
            //    Console.WriteLine("x is indeed greater than y"); //sort of an answer to the questions "is x > y?"
            //    Console.WriteLine("The expression x > y evaluates to true."); // more of a reponse to the statement, "x> y".
            //}
            //if (y > x) // not a question, it is a statement that evalutates to t or f
            //{
            //    //If the expression evaluates to true, this code will run
            //    Console.WriteLine("y > x is true");
            //}
            //else
            //{
            //    // if the expression evaluates to false, this code will run
            //    Console.WriteLine("The expression y > x is false");


            //int size = 250;

            /*
             * although this next code works, it's extra work. After we determine
             * a room is small, we're still checking if the room is medium or large
             if ( size >=1 && size <= 250)
            {
                Console.WriteLine("small room");
            }

            if (size > 250 && size < 650)
            {
                Console.WriteLine("medium room");
            }

            if (size >= 650)
            {
                Console.WriteLine("large room");

            }
            */

            int size = 300;
            if (size >=1 && size <= 250) // range of numbers including the two endpoints
            {
                Console.WriteLine("small room");
            }
            else if (size > 250 && size < 650) // range of numbers but not including the endpoints
            {
                Console.WriteLine("medium room.");
            }
            else 
            {
                Console.WriteLine("large room");
            }

            Console.WriteLine("all done");
        }
    }
}
