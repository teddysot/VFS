using System;
using System.Collections.Generic;
using System.Text;

namespace BackAlleyDiceShooter
{
    class Player
    {
        // Player members
        private static int startBalance = 200;

        private static string playerName;

        private static int playerBalance;

        private static int playerBetAmount;

        private static int playerChoice;

        // Player Constructor
        public Player(string pName)
        {
            playerName = pName;
            playerBalance = startBalance;
        }

        // Get Functions
        public static string getName()
        {
            return playerName;
        }

        public static int getBalance()
        {
            return playerBalance;
        }

        public static int getBetAmount()
        {
            return playerBetAmount;
        }

        public static int getChoice()
        {
            return playerChoice;
        }

        // Set Functions
        public static void setMoney(int amount)
        {
            playerBalance += amount;
        }

        public static void setBetAmount(int amount)
        {
            playerBetAmount = amount;
        }

        public static void setChoice(int choice)
        {
            playerChoice = choice;
        }

        // Reset Balance
        public static void resetMoney()
        {
            playerBalance = startBalance;
        }
    }
}
