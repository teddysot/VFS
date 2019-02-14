using System;
using System.Collections.Generic;
using System.Text;

namespace PetSimulator
{
    class Pet
    {
        public string petName { get; set; }
        public float hunger { get; private set; }
        public float thirst { get; private set; }
        public float sleepiness { get; private set; }
        public float happiness { get; private set; }

        public Pet()
        {
            petName = "DEFAULT NAME";
            hunger = 10.0f;
            thirst = 100.0f;
            sleepiness = 100.0f;
            happiness = 100.0f;
        }

        public void Eat(float amount) // In Grams
        {
            hunger += amount;

            checkMembers();
        }

        public void Walk(float distance) // In Meters
        {
            hunger -= (distance / 80);
            thirst -= (distance / 50);
            sleepiness -= (distance / 80);
            happiness -= (distance / 100);

            checkMembers();
        }

        public void Sleep(float amount) // In Hours
        {
            hunger -= (amount * 5);
            thirst -= (amount * 3);
            sleepiness += (amount * 10);
            happiness -= (amount * 10);

            checkMembers();
        }

        public void Playing(float amount) // In Hours
        {
            hunger -= (amount * 8);
            thirst -= (amount * 5);
            sleepiness -= (amount * 6);
            happiness += (amount * 5);

            checkMembers();
        }

        public void WatchMovie(float amount) // In Hours
        {
            hunger -= (amount * 2);
            thirst -= (amount * 2);
            sleepiness -= (amount * 3);
            happiness += (amount * 10);

            checkMembers();
        }

        public void Toilet()
        {
            hunger -= 5;
            thirst -= 5;
            sleepiness -= 5;
            happiness += 5;

            checkMembers();
        }

        public void Reset()
        {
            hunger = 100.0f;
            thirst = 100.0f;
            sleepiness = 100.0f;
            happiness = 100.0f;
        }

        private void checkMembers()
        {
            if (hunger > 100.0f)
            {
                hunger = 100.0f;
            }

            if (hunger < 0.0f)
            {
                hunger = 0.0f;
            }

            if(thirst > 100.0f)
            {
                thirst = 100.0f;
            }

            if(thirst < 0.0f)
            {
                thirst = 0.0f;
            }

            if (sleepiness > 100.0f)
            {
                sleepiness = 100.0f;
            }

            if (sleepiness < 0.0f)
            {
                sleepiness = 0.0f;
            }

            if (happiness > 100.0f)
            {
                happiness = 100.0f;
            }

            if (happiness < 0.0f)
            {
                happiness = 0.0f;
            }
        }

        public bool checkHealth()
        {
            if(hunger == 0.0f || thirst == 0.0f || sleepiness == 0.0f || happiness == 0.0f)
            {
                return false;
            }
            else if(hunger < 10.0f || thirst < 10.0f || sleepiness < 10.0f || happiness < 10.0f)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n[{0}] ", petName);
                Console.ResetColor();
                Console.Write("I'm dying\n");

                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
