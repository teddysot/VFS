using System;
using System.Collections.Generic;
using System.Text;

namespace PetSimulator
{
    class Game
    {
        public static Player player = new Player();
        public static Pet pet = new Pet();

        public static void Start()
        {
            // Welcome Screen
            Manager.showWelcomeScreen();
            Manager.askPlayerName(player);
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
                        Manager.showResetPetScreen(pet);
                        continue;
                    }

                }
                else
                {
                    Manager.showPauseScreen();
                    Console.Clear();
                    Manager.checkDay();
                    Manager.showCommandScreen(player, pet);
                    Manager.askForCommand(player, pet);
                    Manager.showPetStats(pet);
                }
            }
        }

        public static void Terminate()
        {
            Manager.showEndScreen();
        }
    }
}
