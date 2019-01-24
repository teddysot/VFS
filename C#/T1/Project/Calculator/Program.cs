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
                input = inputNumber("First Number: ");

                // Check is an input is a float
                input = checkFloat("First Number: ", input);

                // Convert input to float
                num1 = float.Parse(input);

                // Prompt an input for second number
                input = inputNumber("Second Number: ");

                // Check is an input is a float
                input = checkFloat("Second Number: ", input);

                // Convert input to float
                num2 = float.Parse(input);

                // Prompt an input for operator
                inputOperator(num1, num2);

                // Prompt user if they want to do another calculation
                repeat = repeatCalculation();
            }

            Console.ReadLine();
        }

        static bool repeatCalculation()
        {
            string aCal = "";
            
            Console.WriteLine("Do you want to do another calculation?");
            Console.WriteLine("1.Yes\n2.No");
            aCal = inputNumber("Choose: ");
            aCal = checkInt("Choose: ", aCal);

            // Check if user inputed an invalid input
            if (aCal != "1" && aCal != "2")
            {
                // Print out error
                Console.WriteLine("[Invalid Input] Unknown option");

                Console.WriteLine("Do you want to do another calculation?");
                Console.WriteLine("1.Yes\n2.No");
                aCal = inputNumber("Choose: ");
                aCal = checkInt("Choose: ", aCal);
            }

            if (aCal == "1")
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

        static string checkInt(string n, string input)
        {
            int temp = -1;
            while (!int.TryParse(input, out temp))
            {
                // Print out error
                Console.WriteLine("[Invalid Input] Not a number");

                input = inputNumber(n);
            }

            return input;
        }

        static string checkFloat(string n, string input)
        {
            float temp = -1.0f;
            while (!float.TryParse(input, out temp))
            {
                // Print out error
                Console.WriteLine("[Invalid Input] Not a number");

                input = inputNumber(n);
            }

            return input;
        }

        static string inputNumber(string n)
        {
            Console.Write("{0}", n);
            return Console.ReadLine();

        }

        // Print Result function
        static void printResult(float num1, float num2, float result, string operation)
        {
            Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, result);
        }
    }
}
