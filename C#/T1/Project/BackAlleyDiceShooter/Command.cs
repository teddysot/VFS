using System;
using System.Collections.Generic;
using System.Text;

namespace BackAlleyDiceShooter
{
    class Commands
    {
        public static void checkCommands(string command)
        {
            // Check command from player intput
            int temp;
            while (!int.TryParse(command, out temp) || temp < 1 || temp > 24)
            {
                // Print out error
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("Invalid command!\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("Choose your bet again: ");
                command = Console.ReadLine();
            }

            Host.askForBetAmount();

            betType bet = (betType)temp;

            switch (bet)
            {
                // Big
                case betType.Big:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Big\n\n");
                    Betting.bigBet();
                    break;

                // Small
                case betType.Small:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Small\n\n");
                    Betting.smallBet();
                    break;

                // Odd
                case betType.Odd:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Odd\n\n");
                    Betting.oddBet();
                    break;

                // Even
                case betType.Even:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Even\n\n");
                    Betting.evenBet();
                    break;

                // Triples
                case betType.All1s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose All 1s\n\n");
                    Betting.allTrippleBet(1);
                    break;
                case betType.All2s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose All 2s\n\n");
                    Betting.allTrippleBet(2);
                    break;
                case betType.All3s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose All 3s\n\n");
                    Betting.allTrippleBet(3);
                    break;
                case betType.All4s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose All 4s\n\n");
                    Betting.allTrippleBet(4);
                    break;
                case betType.All5s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose All 5s\n\n");
                    Betting.allTrippleBet(5);
                    break;
                case betType.All6s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose All 6s\n\n");
                    Betting.allTrippleBet(6);
                    break;

                // Doubles
                case betType.Double1s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Double 1s\n\n");
                    Betting.allDoubleBet(1);
                    break;
                case betType.Double2s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Double 2s\n\n");
                    Betting.allDoubleBet(2);
                    break;
                case betType.Double3s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Double 3s\n\n");
                    Betting.allDoubleBet(3);
                    break;
                case betType.Double4s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Double 4s\n\n");
                    Betting.allDoubleBet(4);
                    break;
                case betType.Double5s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Double 5s\n\n");
                    Betting.allDoubleBet(5);
                    break;
                case betType.Double6s:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Double 6s\n\n");
                    Betting.allDoubleBet(6);
                    break;

                // Any Triple
                case betType.Anytriples:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose Any triples\n\n");
                    Betting.anyTrippleBet();
                    break;

                // Sums
                case betType.fourOrSeventeen:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose 4 or 17\n\n");
                    Betting.fourOrSeventeenBet();
                    break;
                case betType.fiveOrSixteen:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose 5 or 16\n\n");
                    Betting.fiveOrSixteenBet();
                    break;
                case betType.sixOrFifteen:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose 6 or 15\n\n");
                    Betting.sixOrfifteenBet();
                    break;
                case betType.sevenOrFourteen:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose 7 or 14\n\n");
                    Betting.sevenOrfourteenBet();
                    break;
                case betType.eightOrThirteen:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose 8 or 13");
                    Betting.eightOrthirteenBet();
                    break;
                case betType.nineOrTwelve:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose 9 or 12");
                    Betting.nineOrtwelveBet();
                    break;
                case betType.tenOrEleven:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", Player.getName());
                    Console.ResetColor();
                    Console.Write("I choose 10 or 11\n\n");
                    Betting.tenOrelevenBet();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[HOST] ");
                    Console.ResetColor();
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }
}
