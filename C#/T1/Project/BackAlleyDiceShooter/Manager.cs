using System;
using System.Collections.Generic;
using System.Text;

namespace BackAlleyDiceShooter
{
    class Manager
    {
        public static string playerName;

        public static void startGame()
        {
            // Start the game
            playerName = Host.askPlayerName();
            Player player = new Player(playerName, 200);
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

        public static int getBetAmount(string s)
        {
            // Initialize variable
            int playerInput = 0;

            while (!int.TryParse(s, out playerInput))
            {
                // Print out error
                Console.WriteLine("[Invalid Input] Not a number");

                Console.Write("Enter bet amount again: ");
                s = Console.ReadLine();
            }

            return playerInput;
        }
    }
}
