using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Dice
    {
        // Initialize random object for dice
        private static Random nRandom = new Random();

        public static int [] diceRoll(int num)
        {
            // Roll all dices
            int [] dices = new int[num];

            // num is the number of the dices
            for (int i = 0; i < num; i++)
            {
                dices[i] = nRandom.Next(1, 7);
            }

            return dices;
        }

        public int rollTwoDices(Player player)
        {
            int[] diceResult = diceRoll(2);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========================");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[{0}] ", player.Name);
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
    }
}
