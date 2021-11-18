using System;

namespace NumAnalyzer2
{
    class Program
    {
        static bool IsOddUnder60(int num)
            // checking the expression for either true or false
        {
            if (num %2 ==1 && num < 60)
            {
                //when the expression comes back true, return true
                return true;
            }
            else
            {

                return false;
            }
        }

        static bool IsOddOver60(int num)
        {
            //look at this more
            return num % 2 == 1 && num > 60;
        }

        static void Main(string[] args)
        {
            int x = 51;
            if(IsOddUnder60(x) == true)
            {
                Console.WriteLine($"{x} is odd under 60.");
            }
            else if (IsOddOver60(x) == true)
            {
                Console.WriteLine($"{x} is odd over 60.");
            }
        }
    }
}
