using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Manager
    {
        public static void showWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                          Welcome to Monopoly              \n\n\n\n\n");
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

        public static int askNumPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[HOST] ");
            Console.ResetColor();
            Console.Write("How many players want to play this game?\n");
            Console.Write("Enter amount: ");

            // Initialize variable
            string playerInput = Console.ReadLine();

            int temp;
            while (!int.TryParse(playerInput, out temp))
            {
                // Print out error
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("It is not a number\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[HOST] ");
                Console.ResetColor();
                Console.Write("Enter your amount again: ");
                playerInput = Console.ReadLine();
            }

            return temp;
        }

        public static Player [] InitializePlayer(int num)
        {
            Player[] players = new Player[num];
            for (int i = 0; i < num; i++)
            {
                players[i].id = i;
            }

            return players;
        }

        public static Tile [] InitializeTile()
        {
            Tile[] tiles = new Tile[40];

            // Tiles info
            tiles[0].Name = "Start Point";
            tiles[0].Price = 0;
            tiles[0].Color = Colors.NoColor;

            tiles[1].Name = "Mediterranean Avenue";
            tiles[1].Price = 60;
            tiles[1].Color = Colors.Brown;

            tiles[2].Name = "Community Chest";
            tiles[2].Price = 0;
            tiles[2].Color = Colors.Brown;

            tiles[3].Name = "Baltic Avenue";
            tiles[3].Price = 60;
            tiles[3].Color = Colors.NoColor;

            tiles[4].Name = "Income Tax";
            tiles[4].Price = 200;
            tiles[4].Color = Colors.NoColor;

            tiles[5].Name = "Reading Railroad";
            tiles[5].Price = 200;
            tiles[5].Color = Colors.NoColor;

            tiles[6].Name = "Oriental Avenue";
            tiles[6].Price = 100;
            tiles[6].Color = Colors.Cyan;

            tiles[7].Name = "Chance ?";
            tiles[7].Price = 0;
            tiles[7].Color = Colors.NoColor;

            tiles[8].Name = "Vermont Avenue";
            tiles[8].Price = 100;
            tiles[8].Color = Colors.Cyan;

            tiles[9].Name = "Connecticut Avenue";
            tiles[9].Price = 120;
            tiles[9].Color = Colors.Cyan;

            tiles[10].Name = "Just Visiting / Jail";
            tiles[10].Price = 0;
            tiles[10].Color = Colors.NoColor;

            tiles[11].Name = "St.Charles Place";
            tiles[11].Price = 140;
            tiles[11].Color = Colors.Magenta;

            tiles[12].Name = "Electric Company";
            tiles[12].Price = 150;
            tiles[12].Color = Colors.NoColor;

            tiles[13].Name = "States Avenue";
            tiles[13].Price = 140;
            tiles[13].Color = Colors.Magenta;

            tiles[14].Name = "Virginia Avenue";
            tiles[14].Price = 160;
            tiles[14].Color = Colors.Magenta;

            tiles[15].Name = "Pennsylvania Railroad";
            tiles[15].Price = 200;
            tiles[15].Color = Colors.NoColor;

            tiles[16].Name = "St.James Place";
            tiles[16].Price = 180;
            tiles[16].Color = Colors.Orange;

            tiles[17].Name = "Community Chest";
            tiles[17].Price = 0;
            tiles[17].Color = Colors.NoColor;

            tiles[18].Name = "Tennessee Avenue";
            tiles[18].Price = 180;
            tiles[18].Color = Colors.Orange;

            tiles[19].Name = "New York Avenue";
            tiles[19].Price = 200;
            tiles[19].Color = Colors.Orange;

            tiles[20].Name = "Free Parking";
            tiles[20].Price = 0;
            tiles[20].Color = Colors.NoColor;

            tiles[21].Name = "Kentucky Avenue";
            tiles[21].Price = 220;
            tiles[21].Color = Colors.Red;

            tiles[22].Name = "Chance ?";
            tiles[22].Price = 0;
            tiles[22].Color = Colors.NoColor;

            tiles[23].Name = "Indiana Avenue";
            tiles[23].Price = 220;
            tiles[23].Color = Colors.Red;

            tiles[24].Name = "Illinois Avenue";
            tiles[24].Price = 240;
            tiles[24].Color = Colors.Red;

            tiles[25].Name = "B. & O. Railroad";
            tiles[25].Price = 200;
            tiles[25].Color = Colors.NoColor;

            tiles[26].Name = "Atlantic Avenue";
            tiles[26].Price = 260;
            tiles[26].Color = Colors.Yellow;

            tiles[27].Name = "Ventnor Avenue";
            tiles[27].Price = 260;
            tiles[27].Color = Colors.Yellow;

            tiles[28].Name = "Water Works";
            tiles[28].Price = 150;
            tiles[28].Color = Colors.NoColor;

            tiles[29].Name = "Marvin Gardens";
            tiles[29].Price = 280;
            tiles[29].Color = Colors.Yellow;

            tiles[30].Name = "Go To Jail";
            tiles[30].Price = 0;
            tiles[30].Color = Colors.NoColor;

            tiles[31].Name = "Pacific Avenue";
            tiles[31].Price = 300;
            tiles[31].Color = Colors.Green;

            tiles[32].Name = "North Carolina Avenue";
            tiles[32].Price = 300;
            tiles[32].Color = Colors.Green;

            tiles[33].Name = "Community Chest";
            tiles[33].Price = 0;
            tiles[33].Color = Colors.NoColor;

            tiles[34].Name = "Pennsylvania Avenue";
            tiles[34].Price = 320;
            tiles[34].Color = Colors.Green;

            tiles[35].Name = "Short Line";
            tiles[35].Price = 200;
            tiles[35].Color = Colors.NoColor;

            tiles[36].Name = "Chance ?";
            tiles[36].Price = 0;
            tiles[36].Color = Colors.NoColor;

            tiles[37].Name = "Park Place";
            tiles[37].Price = 350;
            tiles[37].Color = Colors.Blue;

            tiles[38].Name = "Luxury Tax";
            tiles[38].Price = 100;
            tiles[38].Color = Colors.NoColor;

            tiles[39].Name = "Boardwalk";
            tiles[39].Price = 400;
            tiles[39].Color = Colors.NoColor;

            return tiles;
        }
    }
}
