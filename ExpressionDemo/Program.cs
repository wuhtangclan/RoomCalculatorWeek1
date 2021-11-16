using System;

namespace ExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = x + y;  // x + y is an "expression". What type do I get when I "evaluate" the expression?

            x = 100;
            y = 3;
            z = x / y; // 33.3333 is not an integer but im storing that number in an integer.


            Console.WriteLine(z);

            //Let's explore booleans

            bool atLunch = false;
            Console.WriteLine(atLunch);

            //Let's do an expression that compares something
            // x has 100 in it, y has 3 in it.
            // Instead of asking it as a question, "Is x greater than y?" which typically we respond with yes or no
            // lets make it a statement, "x is greater than y" and then state whether that statement is true or false.


            bool comp = x > y;
            Console.WriteLine("The statement x > y is either true or false:");
            Console.WriteLine(comp);

            Console.WriteLine("Lets do some direct numbers");
            Console.WriteLine(100 < 3);

            Console.WriteLine("back to variables...");
            Console.WriteLine(x < y); // x has 100, y has 3

            Console.WriteLine("Store the result in a variable");
            comp = x < y; //remember x has 100 and y has 3
            Console.WriteLine(comp);

            Console.WriteLine("Lets try a few boolean comparisons");
            Console.WriteLine(10 > 10);  //false
            Console.WriteLine(10 > 9);  //true
            Console.WriteLine(10 < 9);  //false
            Console.WriteLine(10 == 10);  //true
            Console.WriteLine(10 != 10);  //false
            Console.WriteLine(10 / 2 == 5); //true
            /*Console.WriteLine(10 / 3 ==3);  //wtf. come out true but not really. 
            //just be careful and try not to do this in your code
            */

            string first = "hello";
            string second = "hello";
            Console.WriteLine(first ==second);  // we get "true" in C#, but in some languages like Java will give us false

            second = "Hello";
            Console.WriteLine(first == second);  // we will get false
        }
    }
}
