using System;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intialize Stage
            Game.Start();

            // Game Loop
            Game.Update();

            // End of the Game
            Game.Terminate();
        }
    }
}
