using System;
using System.Collections.Generic;
using System.Text;

namespace BackAlleyDiceShooter
{
    class Host
    {
        public static string askPlayerName()
        {
            // Prompt up input for player
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[HOST] ");
            Console.ResetColor();
            Console.Write("Enter your name: ");
            string pName = Console.ReadLine();
            return pName;
        }

        public static void showCommandScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Player Name: ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0}\n", Player.getName());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Bet Types:\n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1. Big             2. Small        3. Odd          4. Even\n");
            Console.Write("5. All 1s          6. All 2s       7. All 3s       8. All 4s\n");
            Console.Write("9. All 5s          10. All 6s      11. Double 1s   12. Double 2s\n");
            Console.Write("13. Double 3s      14. Double 4s   15. Double 5s   16. Double 6s\n");
            Console.Write("17. Any triples    18. 4 or 17     19. 5 or 16     20. 6 or 15\n");
            Console.Write("21. 7 or 14        22. 8 or 13     23. 9 or 12     24. 10 or 11\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("=========================================================================\n");

            Console.ResetColor();
        }

        public static void askForBetType()
        {
            // Prompt up input for player
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n[HOST] ");
            Console.ResetColor();
            Console.Write("Choose your bet: ");
            string input = Console.ReadLine();
            Commands.checkCommands(input);
        }

        public static void askForBetAmount()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[HOST] ");
            Console.ResetColor();
            Console.Write("Enter your bet ammount: ");

            // Initialize variable
            string playerInput = Console.ReadLine();

            int temp;
            while (!int.TryParse(playerInput, out temp))
            {
                // Print out error
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("It is not a number\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("Enter your bet amount again: ");
                playerInput = Console.ReadLine();
            }

            while(temp > Player.getBalance())
            {
                // Print out error
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You don't have enough balance\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("Enter your bet amount again: ");
                playerInput = Console.ReadLine();

                while (!int.TryParse(playerInput, out temp))
                {
                    // Print out error
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[HOST] ");
                    Console.ResetColor();
                    Console.Write("It is not a number\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[HOST] ");
                    Console.ResetColor();
                    Console.Write("Enter your bet amount again: ");
                    playerInput = Console.ReadLine();
                }
            }

            Player.setBetAmount(temp);
        }

        public static void showBalance()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[HOST] ");
            Console.ResetColor();
            Console.Write("Your balance: {0}\n", Player.getBalance());
        }
        public static void showWonScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[HOST] ");
            Console.ResetColor();
            Console.Write("You exceeded our limit now.\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[HOST] ");
            Console.ResetColor();
            Console.Write("Sorry, You have to leave\n");
        }

        public static void showLostScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[HOST] ");
            Console.ResetColor();
            Console.Write("Sorry, You are broke now.\n");
        }

        public static void showResetBalanceScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n[HOST] ");
            Console.ResetColor();
            Console.Write("Your balance has been reset to $200.\n");

            pauseScreen();
        }

        public static void pauseScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n[HOST] ");
            Console.ResetColor();
            Console.Write("Press any key to continue.\n");
            Console.ReadLine();
        }
    }
}
