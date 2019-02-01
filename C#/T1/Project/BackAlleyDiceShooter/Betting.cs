using System;
using System.Collections.Generic;
using System.Text;

namespace BackAlleyDiceShooter
{
    enum betType
    {
        Big = 1,
        Small = 2,
        Odd = 3,
        Even = 4,
        All1s = 5,
        All2s = 6,
        All3s = 7,
        All4s = 8,
        All5s = 9,
        All6s = 10,
        Double1s = 11,
        Double2s = 12,
        Double3s = 13,
        Double4s = 14,
        Double5s = 15,
        Double6s = 16,
        Anytriples = 17,
        fourOrSeventeen = 18,
        fiveOrSixteen = 19,
        sixOrFifteen = 20,
        sevenOrFourteen = 21,
        eightOrThirteen = 22,
        nineOrTwelve = 23,
        tenOrEleven = 24
    }

    class Betting
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

        public static int rollThreeDices()
        {
            int[] diceResult = diceRoll();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========================");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[HOST] ");
            Console.ResetColor();

            Console.Write("Rolling dice…\n\n");

            // Adding total dice result
            int diceResultSum = 0;

            for (int i = 0; i < diceResult.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();

                Console.Write("Dice {0}: {1}\n", i + 1, diceResult[i]);
                diceResultSum += diceResult[i];
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[HOST] ");
            Console.ResetColor();

            Console.Write("Sum: {0}\n", diceResultSum);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========================");
            Console.ResetColor();

            return diceResultSum;
        }

        public static int getTripple()
        {
            return nTriple;
        }

        public static int getDouble()
        {
            return nDouble;
        }

        public static void setTripple(int t)
        {
            nTriple = t;
        }

        public static void setDouble(int d)
        {
            nDouble = d;
        }

        // Bet Functions
        public static void bigBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result >= 11 && result <= 17)
            {
                Player.setMoney(Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the Big bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the Big bet!\n");
            }
        }

        public static void smallBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result >= 4 && result <= 10)
            {
                Player.setMoney(Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the Small bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the Small bet!\n");
            }
        }

        public static void oddBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result % 2 != 0)
            {
                Player.setMoney(Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the Odd bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the Odd bet!\n");
            }
        }

        public static void evenBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result % 2 == 0)
            {
                Player.setMoney(Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the Even bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("[HOST] You lost the Even bet!\n");
            }
        }

        public static void fourOrSeventeenBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result == 4 || result == 17)
            {
                Player.setMoney(Player.getBetAmount() * 60);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the 4 or 17 bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the 4 or 17 bet!\n");
            }
        }

        public static void fiveOrSixteenBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result == 5 || result == 16)
            {
                Player.setMoney(Player.getBetAmount() * 30);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the 5 or 16 bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the 5 or 16 bet!\n");
            }
        }

        public static void sixOrfifteenBet()
        {
            // Roll dices
            int result = rollThreeDices();

            if (result == 6 || result == 15)
            {
                Player.setMoney(Player.getBetAmount() * 18);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the 6 or 15 bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the 6 or 15 bet!\n");
            }
        }

        public static void sevenOrfourteenBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result == 7 || result == 14)
            {
                Player.setMoney(Player.getBetAmount() * 12);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the 7 or 14 bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the 7 or 14 bet!\n");
            }
        }

        public static void eightOrthirteenBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result == 8 || result == 13)
            {
                Player.setMoney(Player.getBetAmount() * 8);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the 8 or 13 bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You Lost the 8 or 13 bet!\n");
            }
        }

        public static void nineOrtwelveBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result == 9 || result == 12)
            {
                Player.setMoney(Player.getBetAmount() * 7);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the 9 or 12 bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the 9 or 12 bet!\n");
            }
        }

        public static void tenOrelevenBet()
        {
            // Roll dices
            int result = rollThreeDices();

            // Check the result
            if (result == 10 || result == 11)
            {
                Player.setMoney(Player.getBetAmount() * 6);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the 10 or 11 bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the 10 or 11 bet!\n");
            }
        }

        public static void allTrippleBet(int t)
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Check the result
            if (diceResult[0] == t && diceResult[0] == diceResult[1] && diceResult[0] == diceResult[2])
            {
                Player.setMoney(Player.getBetAmount() * 180);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the Tripple bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the Tripple bet!\n");
            }
        }

        public static void anyTrippleBet()
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Check the result
            if (diceResult[0] == diceResult[1] && diceResult[0] == diceResult[2])
            {
                Player.setMoney(Player.getBetAmount() * 30);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the Tripple bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You lost the Tripple bet!\n");
            }
        }

        public static void allDoubleBet(int d)
        {
            // Roll dices
            int[] diceResult = diceRoll();

            // Check the result
            if (diceResult[0] == d && diceResult[0] == diceResult[1] || diceResult[0] == d && diceResult[0] == diceResult[2] || diceResult[1] == d && diceResult[1] == diceResult[2])
            {
                Player.setMoney(Player.getBetAmount() * 10);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("You won the Double bet!\n");
            }
            else
            {
                Player.setMoney(-Player.getBetAmount());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("[HOST] You lost the Double bet!\n");
            }
        }
    }
}
