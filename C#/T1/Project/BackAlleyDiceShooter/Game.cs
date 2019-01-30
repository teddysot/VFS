using System;
using System.Collections.Generic;
using System.Text;

namespace BackAlleyDiceShooter
{
    class Game
    {
        // Store bet values
        private static int nTriple;
        private static int nDouble;

        // Initialize random object for dice
        static Random nRandom = new Random();

        static int[] diceRoll()
        {
            // Roll all dices
            int[] dice = { nRandom.Next(1, 7), nRandom.Next(1, 7), nRandom.Next(1, 7) };
            return dice;
        }

        // Bet Functions
        public static void bigBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum >= 11 && diceResultSum <= 17)
            {
                Player.setMoney(Player.getBetAmount());
                Console.WriteLine("[HOST] You won the Big bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the Big bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void smallBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum >= 4 && diceResultSum <= 10)
            {
                Player.setMoney(Player.getBetAmount());
                Console.WriteLine("[HOST] You won the Small bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the Small bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void oddBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum % 2 != 0)
            {
                Player.setMoney(Player.getBetAmount());
                Console.WriteLine("[HOST] You won the Odd bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the Odd bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void evenBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum % 2 == 0)
            {
                Player.setMoney(Player.getBetAmount());
                Console.WriteLine("[HOST] You won the Even bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the Even bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void fourOrSeventeenBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum == 4 || diceResultSum == 17)
            {
                Player.setMoney(Player.getBetAmount() * 60);
                Console.WriteLine("[HOST] You won the 4 or 17 bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the 4 or 17 bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void fiveOrSixteenBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum == 5 || diceResultSum == 16)
            {
                Player.setMoney(Player.getBetAmount() * 30);
                Console.WriteLine("[HOST] You won the 5 or 16 bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the 5 or 16 bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void sixOrfifteenBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            if (diceResultSum == 6 || diceResultSum == 15)
            {
                Player.setMoney(Player.getBetAmount() * 18);
                Console.WriteLine("[HOST] You won the 6 or 15 bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the 6 or 15 bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void sevenOrfourteenBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum == 7 || diceResultSum == 14)
            {
                Player.setMoney(Player.getBetAmount() * 12);
                Console.WriteLine("[HOST] You won the 7 or 14 bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the 7 or 14 bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void eightOrthirteenBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum == 8 || diceResultSum == 13)
            {
                Player.setMoney(Player.getBetAmount() * 8);
                Console.WriteLine("[HOST] You won the 8 or 13 bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You Lost the 8 or 13 bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void nineOrtwelveBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum == 9 || diceResultSum == 12)
            {
                Player.setMoney(Player.getBetAmount() * 7);
                Console.WriteLine("[HOST] You won the 9 or 12 bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the 9 or 12 bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void tenOrelevenBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Adding total dice result
            int diceResultSum = 0;
            foreach (int result in diceResult)
            {
                diceResultSum += result;
            }

            Console.WriteLine("Sum of the dice is: {0}", diceResultSum);

            // Check the result
            if (diceResultSum == 10 || diceResultSum == 11)
            {
                Player.setMoney(Player.getBetAmount() * 6);
                Console.WriteLine("[HOST] You won the 10 or 11 bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the 10 or 11 bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void specificTrippleBet(int t)
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Check the result
            if (diceResult[0] == t && diceResult[0] == diceResult[1] && diceResult[0] == diceResult[2])
            {
                Player.setMoney(Player.getBetAmount() * 180);
                Console.WriteLine("[HOST] You won the Tripple bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the Tripple bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void anyTrippleBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Check the result
            if (diceResult[0] == diceResult[1] && diceResult[0] == diceResult[2])
            {
                Player.setMoney(Player.getBetAmount() * 30);
                Console.WriteLine("[HOST] You won the Tripple bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the Tripple bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }

        public static void specificDoubleBet(int d)
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Check the result
            if (diceResult[0] == d && diceResult[0] == diceResult[1] || diceResult[0] == d && diceResult[0] == diceResult[2] || diceResult[1] == d && diceResult[1] == diceResult[2])
            {
                Player.setMoney(Player.getBetAmount() * 10);
                Console.WriteLine("[HOST] You won the Double bet!");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.WriteLine("[HOST] You lost the Double bet!");
            }

            // Show balance
            Console.WriteLine("[HOST] Your balance: {0}", Player.getBalance());
        }
    }
}
