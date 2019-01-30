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
            Console.Write("[HOST] Enter your name: ");
            string pName = Console.ReadLine();
            return pName;
        }

        public static void askForBet()
        {
            // Prompt up input for player
            Console.Write("Enter bet ammount: ");
        }
    }
}
