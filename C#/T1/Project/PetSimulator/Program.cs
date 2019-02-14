using System;

namespace PetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the Game
            Game.Start();

            // Game Loop
            Game.Update();

            // Terminate the Game
            Game.Terminate();
        }
    }
}
