using System;

namespace W1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a message to the screen
            Console.WriteLine("Hello World!");

            int myInteger = 5;

            // Print the integer
            Console.WriteLine(myInteger);

            // Propmpt the user for input
            Console.WriteLine("Type something:");

            // Read an input string from use
            string input = Console.ReadLine();

            // int.Parse() converts a string to an integer
            int iInput = int.Parse(input);

            // float.Parse() converts astring to a float
            float fInput = float.Parse(input);

            // Print input string
            Console.WriteLine("You typed {0}", input);

            // Perforom some math
            float result = iInput + fInput;
            Console.WriteLine("{0} + {1} = {2}", iInput, fInput, result);

            // Wait for the user to hit <Enter>
            Console.ReadLine();
        }
    }
}
