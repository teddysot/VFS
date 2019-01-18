using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Sequence");
            Console.Write("Enter number of sequence: ");
            int s = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 0;
            int c = 0;

            int n = 0;
            while (n < s)
            {
                c = a + b;
                a = b;
                b = c;
                n++;
            }
            

            Console.WriteLine("{0}", c);

            Console.ReadLine();
        }
    }
}
