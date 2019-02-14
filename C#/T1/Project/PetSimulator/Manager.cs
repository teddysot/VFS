using System;
using System.Collections.Generic;
using System.Text;

namespace PetSimulator
{
    class Manager
    {
        private static int dayCount = 1;

        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        private static int i = 0;
        private static int count = 0;
        public static void checkDay()
        {
            if (count != 2)
            {
                count++;
            }
            else if (count == 2)
            {
                i++;
                count = 0;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("Day ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}\n", dayCount);
            Console.ResetColor();

            Days days = (Days)i;
            switch (days)
            {
                case Days.Monday:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Today is ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("{0}\n", days);
                    Console.ResetColor();
                    break;
                case Days.Tuesday:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Today is ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("{0}\n", days);
                    Console.ResetColor();
                    break;
                case Days.Wednesday:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Today is ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0}\n", days);
                    Console.ResetColor();
                    break;
                case Days.Thursday:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Today is ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("{0}\n", days);
                    Console.ResetColor();
                    break;
                case Days.Friday:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Today is ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("{0}\n", days);
                    Console.ResetColor();
                    break;
                case Days.Saturday:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Today is ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("{0}\n", days);
                    Console.ResetColor();
                    break;
                case Days.Sunday:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[GAME] ");
                    Console.ResetColor();
                    Console.Write("Today is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0}\n", days);
                    Console.ResetColor();
                    break;
            }

            dayCount++;
        }

        public static void showWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("               Welcome to Tamagottagettemall Pet Simulator              \n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                     Press any key to start the game                    \n\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n");
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void showEndScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                Good Bye!              \n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                     Press any key to exit the game                    \n\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n");
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void showDeathScreen(Pet p)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("{0} Died!\n", p.petName);
        }

        public static void showResetPetScreen(Pet p)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("{0}'s stats has been reset\n", p.petName);
            p.Reset();
        }

        public static void showCommandScreen(Player player, Pet pet)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("Hi {0}, Welcome to the game\n", player.playerName);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("What would you like to do today?\n");
            Console.WriteLine("1. Feed {0}", pet.petName);
            Console.WriteLine("2. Walk {0}", pet.petName);
            Console.WriteLine("3. Sleep {0}", pet.petName);
            Console.WriteLine("4. Play {0}", pet.petName);
            Console.WriteLine("5. Movie {0}", pet.petName);
            Console.WriteLine("6. Toilet {0}", pet.petName);
        }

        public static void showPetStats(Pet pet)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("[{0}] ", pet.petName);
            Console.ResetColor();
            Console.Write("Stats:\n");
            Console.WriteLine("Hunger: {0}", pet.hunger);
            Console.WriteLine("Thirst: {0}", pet.thirst);
            Console.WriteLine("Sleepiness: {0}", pet.sleepiness);
            Console.WriteLine("Happiness: {0}", pet.happiness);
            Console.Write("\n");
        }

        public static void showPauseScreen()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }

        public static bool checkPet(Pet p)
        {
            return p.checkHealth();
        }

        public static void askPlayerName(Player p)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("Enter Player Name: ");
            p.playerName = Console.ReadLine();
        }

        public static void askPetName(Pet p)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("Enter Pet Name: ");
            p.petName = Console.ReadLine();
        }

        public static void askForCommand(Player player, Pet pet)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Command.checkCommands(choice, player, pet);
        }

        public static bool askToPlayAgain()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("Do you want to play again?\n");
            Console.WriteLine("Y - Yes | N - No");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[GAME] ");
            Console.ResetColor();
            Console.Write("Enter your choice: ");
            string decision = Console.ReadLine();

            if (decision == "Y" || decision == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
