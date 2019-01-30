using System;
using System.Collections.Generic;
using System.Text;

namespace BackAlleyDiceShooter
{
    class Player
    {
        // Player members
        private static string playerName;

        private static int playerBalance;

        private static int playerBetAmount;

        private static int playerMove;

        // Player Constructor
        public Player(string pName, int pBalance)
        {
            playerName = pName;
            playerBalance = pBalance;
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

        public static int getMove()
        {
            return playerMove;
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

        public static void setMove(int move)
        {
            playerMove = move;
        }

        // Reset Balance
        public static void resetMoney()
        {
            playerBalance = 200;
        }
    }
}
