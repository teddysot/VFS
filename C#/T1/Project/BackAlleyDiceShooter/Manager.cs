using System;
using System.Collections.Generic;
using System.Text;

namespace BackAlleyDiceShooter
{
    class Manager
    {
        public static string playerName;

        public static void showWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                    Welcome to Back Alley Dice Shooter              \n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                     Press any key to start the game                    \n\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n");
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void showEndScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                Good Bye!              \n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                     Press any key to exit the game                    \n\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n");
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void startGame()
        {
            // Start the game
            playerName = Host.askPlayerName();
            Player player = new Player(playerName);
        }
        public static bool checkWin()
        {
            // Check player balance
            if (Player.getBalance() >= 100000)
            {
                return true;
            }
            return false;
        }

        public static bool checkLose()
        {
            // Check player balance
            if (Player.getBalance() <= 0)
            {
                return true;
            }
            return false;
        }

        public static string askToPlayAgain()
        {
            string input = "";

            while (input != "y" || input != "Y" || input != "n" || input != "N")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n[HOST] ");
                Console.ResetColor();
                Console.Write("Do you want to play again?\n");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Y - Yes");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("N - No\n");
                Console.ResetColor();
                input = Console.ReadLine();
                if (input == "y" || input == "Y" || input == "n" || input == "N")
                {
                    Player.resetMoney();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[HOST] ");
                    Console.ResetColor();
                    Console.Write("Invalid Input!");
                }
            }
            return input;
        }
    }
}
