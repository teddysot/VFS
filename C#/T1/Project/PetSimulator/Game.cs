using System;
using System.Collections.Generic;
using System.Text;

namespace PetSimulator
{
    class Game
    {
        // Initialize Player and Pet
        public static Player player = new Player();
        public static Pet pet = new Pet();

        public static void Start()
        {
            // Welcome Screen
            Manager.showWelcomeScreen();

            // Set Player Name
            Manager.askPlayerName(player);

            // Set Pet Name
            Manager.askPetName(pet);
        }

        public static void Update()
        {
            bool isRunning = true;
            // Game loop
            while (isRunning)
            {
                // Check Pet
                if (!Manager.checkPet(pet))
                {
                    // Print death screen
                    Manager.showDeathScreen(pet);

                    // Ask player decision
                    bool decision = Manager.askToPlayAgain();
                    if (!decision)
                    {
                        isRunning = false;
                        break;
                    }
                    else
                    {
                        // Reset Pet Stats
                        Manager.showResetPetScreen(pet);
                        continue;
                    }

                }
                else
                {
                    // Pause screen for player, so they can read a stat
                    Manager.showPauseScreen();
                    Console.Clear();

                    // Check day
                    Manager.checkDay();

                    // Show commands for a player
                    Manager.showCommandScreen(player, pet);

                    // Ask player an input for command
                    Manager.askForCommand(player, pet);

                    // Show Pet Stats
                    Manager.showPetStats(pet);
                }
            }
        }

        public static void Terminate()
        {
            // Show End Screen
            Manager.showEndScreen();
        }
    }
}
