using System;

namespace Bonus_Bonus_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt input for user
            Console.Write("Input 4 digit numbers: ");

            // Reading input
            int input = int.Parse(Console.ReadLine());

            /* 
             result = 0
             remainder = input % 10
             remainder = (result * 10) + remainder
             input = input / 10

             Assuming input = 1234

             Loop 1
             4   = 1234 % 10
             4   = (0 * 10) + 4
             123 = 1234 / 10

             Loop 2
             3   = 123 % 10
             43   = (4 * 10) + 3
             12 = 123 / 10

             Loop 3
             2   = 12 % 10
             432   = (43 * 10) + 2
             1 = 12 / 10

             Loop 4
             1   = 1 % 10
             4321   = (1 * 10) + 1
             0 = 1 / 10
             */

            int reverse = 0;
            
            // 4 digits
            int r = input % 10;
            reverse = (reverse * 10) + r;
            input = input / 10;

            // 3 digits
            r = input % 10;
            reverse = (reverse * 10) + r;
            input = input / 10;

            // 2 digits
            r = input % 10;
            reverse = (reverse * 10) + r;
            input = input / 10;

            // 1 digit
            r = input % 10;
            reverse = (reverse * 10) + r;
            input = input / 10;

            Console.WriteLine("Reverse: {0}", reverse);
            Console.ReadLine();
        }
    }
}
