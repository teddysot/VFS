using System;
using System.Collections.Generic;
using System.Text;

namespace PetSimulator
{
    class Player
    {
        public string playerName { get; set; }

        public Player()
        {
            playerName = "DEFAULT NAME";
        }

        public void feedingPet(Pet p, float amount)
        {
            p.Eat(amount);
        }

        public void goForWalk(Pet p, float distance)
        {
            p.Walk(distance);
        }

        public void goForSleep(Pet p, float amount)
        {
            p.Sleep(amount);
        }

        public void goForPlay(Pet p, float amount)
        {
            p.Playing(amount);
        }

        public void goForMovie(Pet p, float amount)
        {
            p.WatchMovie(amount);
        }

        public void goForToilet(Pet p)
        {
            p.Toilet();
        }
    }
}
