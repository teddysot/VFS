using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Propmpt the user for input a
            Console.Write("a:");
            int a = int.Parse(Console.ReadLine());

            // Propmpt the user for input b
            Console.Write("b:");
            int b = int.Parse(Console.ReadLine());

            // Formula
            int result = a + b;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("{0} + {1} = {2}", a, b, result);

            Console.ReadLine();
        }
    }
}
