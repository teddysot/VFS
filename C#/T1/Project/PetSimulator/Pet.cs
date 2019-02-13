using System;
using System.Collections.Generic;
using System.Text;

namespace W5_Exercise2
{
    class Pet
    {
        private string Name;
        private float Hunger = 100.0f;
        private float Thirst = 100.0f;
        private float Sleepiness = 100.0f;
        private float Happiness = 100.0f;

        public Pet()
        {
            Name = "DEFAULT NAME";
        }

        public Pet(string pName)
        {
            Name = pName;
        }

        public void Eat(float amount)
        {
            Hunger -= amount;
            if(Hunger < 0)
            {
                Hunger = 0;
            }
        }

        public void Walk(float distance)
        {
            Hunger = (distance / 100) - Hunger;
            Thirst = (distance / 200) - Thirst;
            Sleepiness = (distance / 200) - Sleepiness;
            Happiness = (distance / 200) - Happiness;
        }

        public void Sleep(float amount)
        {
            Hunger = (amount * 5) - Hunger;
            Thirst = (amount * 3) - Thirst;
            Sleepiness = (amount * 10) + Sleepiness;
            Happiness = (amount * 10) - Happiness;
        }

        public void WatchMovie(float amount)
        {

        }

        public void Dropping()
        {

        }

        public void RollOver(float pHunger, float pSleep, float pHappy)
        {
            Hunger += pHunger;
            Sleepiness += pSleep;
            Happiness += pHappy;

            if(Hunger > 100.0f)
            {
                Hunger = 100.0f;
            }

            if (Sleepiness > 100.0f)
            {
                Sleepiness = 100.0f;
            }

            if (Happiness > 100.0f)
            {
                Happiness = 100.0f;
            }
        }

        // Setter Functions
        public void setName(string pName)
        {
            Name = pName;
        }

        public void setHunger(float pHunger)
        {
            Hunger = pHunger;
        }

        public void setThirst(float pThirst)
        {
            Thirst = pThirst;
        }

        public void setSleepiness(float pSleep)
        {
            Sleepiness = pSleep;
        }

        public void setHappiness(float pHappy)
        {
            Happiness = pHappy;
        }


        // Getter Functions
        public string getName()
        {
            return Name;
        }

        public float getHunger()
        {
            return Hunger;
        }

        public float getThirst()
        {
            return Thirst;
        }

        public float getSleepiness()
        {
            return Sleepiness;
        }

        public float getHappiness()
        {
            return Happiness;
        }
    }
}
