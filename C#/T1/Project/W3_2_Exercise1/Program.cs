using System;

namespace TriangleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int depth = inputNumberOfDepth();

            printTriangleNumber(depth);
            
            Console.ReadLine();
        }

        static void printTriangleNumber(int n)
        {
            int counter = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("{0} ", counter);
                    counter++;
                }
                Console.WriteLine();
            }
        }

        static int inputNumberOfDepth()
        {
            Console.Write("Enter number of depth: ");

            int temp = -1;
            string input = Console.ReadLine();

            while (!int.TryParse(input, out temp))
            {
                // Print out error
                Console.WriteLine("[Invalid Input] Not a number");

                Console.Write("Enter number again: ");
                input = Console.ReadLine();
            }

            return temp;
        }
    }
}
