using System;
/*
    - PG15 T1 Intro to Programming C# Assignment 1
    - Made by Teddy Nasahachart
    - Some game structure idea inspired from https://github.com/Eric-JT/BackAlleyDiceShooter
*/

namespace BackAlleyDiceShooter
{
    class Program
    {
        public static Boolean isRunning = true;
        static void Main(string[] args)
        {
            // Welcome Screen
            Manager.showWelcomeScreen();

            // Start the game
            Manager.startGame();

            // Game loop
            while (isRunning)
            {
                // Check Lose Condition
                if (Manager.checkLose())
                {
                    // Print lost screen
                    Host.showLostScreen();

                    // Ask player decision
                    string decision = Manager.askToPlayAgain();
                    if (decision == "n" || decision == "N")
                    {
                        isRunning = false;
                        break;
                    }
                    else
                    {
                        // Print reset balance screen
                        Host.showResetBalanceScreen();
                        continue;
                    }

                }
                else if (Manager.checkWin())
                {
                    // Check Win condition
                    Host.showWonScreen();

                    string decision = Manager.askToPlayAgain();
                    if (decision == "n" || decision == "N")
                    {
                        isRunning = true;
                        break;
                    }
                    else
                    {
                        Host.showResetBalanceScreen();
                        continue;

                    }
                }
                else
                {
                    // Continuing Game
                    Host.showCommandScreen();
                    Host.showBalance();
                    Host.askForBetType();
                }
                // Show Balance
                Host.showBalance();
                Host.pauseScreen();
            }
            // Show End Screen
            Manager.showEndScreen();
        }
    }
}
