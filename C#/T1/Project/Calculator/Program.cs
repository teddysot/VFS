using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            string input;
            bool repeat = true;

            while(repeat)
            {
                // Prompt an input for first number
                Console.Write("First Number: ");
                input = inputNumber();

                // Check is an input is a float
                num1 = checkFloat(input);

                // Prompt an input for second number
                Console.Write("Second Number: ");
                input = inputNumber();

                // Check is an input is a float
                num2 = checkFloat(input);

                // Prompt an input for operator
                inputOperator(num1, num2);

                // Prompt user if they want to do another calculation
                repeat = repeatCalculation();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        static bool repeatCalculation()
        {
            int aCal = 0;
            
            Console.WriteLine("Do you want to do another calculation?");
            Console.WriteLine("1.Yes\n2.No");
            Console.Write("Choose: ");
            aCal = checkInt(inputNumber());

            // Check if user inputed an invalid input
            if (aCal != 1 && aCal != 2)
            {
                // Print out error
                Console.WriteLine("[Invalid Input] Unknown option");

                Console.WriteLine("Do you want to do another calculation?");
                Console.WriteLine("1.Yes\n2.No");
                Console.Write("Choose: ");
                aCal = checkInt(inputNumber());
            }

            if (aCal == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void inputOperator(float num1, float num2)
        {
            Console.WriteLine("Choose your operator[ + , - , *, / , %, p ]");
            string operation = Console.ReadLine();

            // Loop if input is not null
            while (operation != null)
            {
                switch(operation)
                {
                    case "+":
                        printResult(num1, num2, num1 + num2, operation);
                        return;
                    case "-":
                        printResult(num1, num2, num1 - num2, operation);
                        return;
                    case "*":
                        printResult(num1, num2, num1 * num2, operation);
                        return;
                    case "/":
                        printResult(num1, num2, num1 / num2, operation);
                        return;
                    case "%":
                        printResult(num1, num2, num1 % num2, operation);
                        return;
                    case "p":
                    case "P":
                        printResult(num1, num2, ((float)Math.Pow(num1, num2)), operation);
                        return;
                    default:
                        // Print out error
                        Console.WriteLine("[Invalid Input] Unknown operator");
                        break;

                }

                Console.WriteLine("Choose your operator[ + , - , *, / , % ]");
                operation = Console.ReadLine();
            }
        }

        static int checkInt(string input)
        {
            int temp = -1;
            while (!int.TryParse(input, out temp))
            {
                // Print out error
                Console.WriteLine("[Invalid Input] Not a number");

                Console.Write("Choose: ");
                input = inputNumber();
            }

            return temp;
        }

        static float checkFloat(string input)
        {
            float temp = -1.0f;
            while (!float.TryParse(input, out temp))
            {
                // Print out error
                Console.WriteLine("[Invalid Input] Not a number");

                Console.Write("Enter again: ");
                input = inputNumber();
            }

            return temp;
        }

        static string inputNumber()
        {
            return Console.ReadLine();
        }

        // Print Result function
        static void printResult(float num1, float num2, float result, string operation)
        {
            Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, result);
        }
    }
}
