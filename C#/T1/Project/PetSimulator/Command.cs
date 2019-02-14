using System;
using System.Collections.Generic;
using System.Text;

namespace PetSimulator
{
    enum Commands
    {
        Feed = 1,
        Walk,
        Sleep,
        Play,
        Movie,
        Toilet
    }

    class Command
    {
        public static void checkCommands(string command, Player player, Pet pet)
        {
            // Check command from player intput
            int temp;
            while (!int.TryParse(command, out temp) || temp < 1 || temp > 6)
            {
                // Print out error
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[GAME] ");
                Console.ResetColor();
                Console.Write("Invalid command!\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[GAME] ");
                Console.ResetColor();
                Console.Write("Choose your choice again: ");
                command = Console.ReadLine();
            }

            Commands pb = (Commands)temp;

            switch(pb)
            {
                case Commands.Feed:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Enter Amount (gram): ");
                    string amount = Console.ReadLine();
                    int temp1;
                    while (!int.TryParse(amount, out temp1))
                    {
                        // Print out error
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Invalid amount!\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Enter your amount again (gram): ");
                        amount = Console.ReadLine();
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", player.playerName);
                    Console.ResetColor();
                    Console.Write("I choose Feed and {0} grams of food\n\n", temp1);
                    player.feedingPet(pet, temp1);
                    break;

                case Commands.Walk:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Enter Amount (meter): ");
                    amount = Console.ReadLine();

                    while (!int.TryParse(amount, out temp1))
                    {
                        // Print out error
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Invalid amount!\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Enter your amount again (meter): ");
                        amount = Console.ReadLine();
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", player.playerName);
                    Console.ResetColor();
                    Console.Write("I choose Walk and {0} meter(s)\n\n", temp1);
                    player.goForWalk(pet, temp1);
                    break;

                case Commands.Sleep:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Enter Amount (hour): ");
                    amount = Console.ReadLine();

                    while (!int.TryParse(amount, out temp1))
                    {
                        // Print out error
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Invalid amount!\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Enter your amount again (hour): ");
                        amount = Console.ReadLine();
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", player.playerName);
                    Console.ResetColor();
                    Console.Write("I choose Sleep and {0} hour(s)\n\n", temp1);
                    player.goForSleep(pet, temp1);
                    break;

                case Commands.Play:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Enter Amount (hour): ");
                    amount = Console.ReadLine();

                    while (!int.TryParse(amount, out temp1))
                    {
                        // Print out error
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Invalid amount!\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Enter your amount again (hour): ");
                        amount = Console.ReadLine();
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", player.playerName);
                    Console.ResetColor();
                    Console.Write("I choose Play and {0} hour(s)\n\n", temp1);
                    player.goForPlay(pet, temp1);
                    break;

                case Commands.Movie:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Enter Amount (hour): ");
                    amount = Console.ReadLine();

                    while (!int.TryParse(amount, out temp1))
                    {
                        // Print out error
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Invalid amount!\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[GAME] ");
                        Console.ResetColor();
                        Console.Write("Enter your amount again (hour): ");
                        amount = Console.ReadLine();
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", player.playerName);
                    Console.ResetColor();
                    Console.Write("I choose Movie and {0} hour(s)\n\n", temp1);
                    player.goForMovie(pet, temp1);
                    break;

                case Commands.Toilet:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[{0}] ", player.playerName);
                    Console.ResetColor();
                    Console.Write("I choose Toilet(s)\n\n");
                    player.goForToilet(pet);
                    break;
            }
        }
    }
}
