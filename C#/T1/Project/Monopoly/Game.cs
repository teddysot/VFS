using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Game
    {
        public static void Start()
        {
            
            int numPlayer = Manager.askNumPlayer();

            Player[] players = Manager.InitializePlayer(numPlayer);
            Tile[] tiles = Manager.InitializeTile();
        }

        // Game Mechanics and Logics
        public static void Update()
        {
            
            bool isRunning = true;
            // Game loop
            while (isRunning)
            {
                // Render Board
                // Check Lose
                // Check Win
                // Check Turn
                // Roll Dice
                // Check Position and Tile
                // Check Tile type
                // Check Property Owner
                // Check Cost
                // Check Special Chest / Draw Card
            }
        }

        public static void Terminate()
        {
            // End of the Game
            Manager.showEndScreen();
        }
    }
}
