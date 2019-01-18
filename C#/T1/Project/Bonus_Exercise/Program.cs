using System;

namespace Bonus_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Farenheit to Celsius Degrees Converter");
            Console.WriteLine("2.Celsius to Farenheit Degrees Converter");
            Console.Write("Make your selection: ");

            int choice = int.Parse(Console.ReadLine());

            // Switch statement for user selection
            switch(choice)
            {
                case 1:
                    {
                        FarenheitToCelsius();
                        break;
                    }
                case 2:
                    {
                        CelsiusToFarenheit();
                        break;
                    }
                default:
                    FarenheitToCelsius();
                    break;
            }

            // Pause application
            Console.ReadLine();
        }

        static void FarenheitToCelsius()
        {
            // Prompt user input
            Console.Write("Input Fahrenheit: ");
            float f = float.Parse(Console.ReadLine());

            // Convert Fahrenheit Degrees to Celsius
            float c = ((f - 32) * 5 / 9);

            Console.WriteLine("Fahrenheit: {0}", f);
            Console.WriteLine("Celsius: {0}", c);
            CheckTemperature(c, f);
        }

        static void CelsiusToFarenheit()
        {
            // Prompt user input
            Console.Write("Input Celsius: ");
            float c = float.Parse(Console.ReadLine());

            // Convert Celsius to Farenheit
            float f = (c * 9 / 5) + 32;

            Console.WriteLine("Celsius: {0}", c);
            Console.WriteLine("Fahrenheit: {0}", f);
            CheckTemperature(c, f);
        }

        static void CheckTemperature(float c, float f)
        {
            if (c >= 100.0f || f >= 212.0f)
            {
                Console.WriteLine("Careful! Hot temperature!");
                //return;
            }
            else if (c <= 0.0f || f <= 32.0f)
            {
                Console.WriteLine("Careful! Freezing temperature!");
                //return;
            }
        }
    }
}
