#include <iostream>

#include "ConsoleColor.h"
#include "Pet.h"

using namespace std;

ConsoleColor cc;

Pet::Pet() :
	petName("DEFAULT NAME"),
	hunger(10.0f),
	thirst(10.0f),
	sleepiness(10.0f),
	happiness(10.0f)
{}

Pet::~Pet()
{}

void Pet::setName(std::string name)
{
	petName = name;
}

std::string Pet::getName()
{
	return petName;
}

float Pet::getHunger()
{
	return hunger;
}

float Pet::getThirst()
{
	return thirst;
}

float Pet::getSleepiness()
{
	return sleepiness;
}

float Pet::getHappiness()
{
	return happiness;
}

void Pet::Eat(float amount)
{
	hunger += amount;

	checkStats();
}

void Pet::Walk(float distance)
{
	hunger -= (distance / 80);
	thirst -= (distance / 50);
	sleepiness -= (distance / 80);
	happiness -= (distance / 100);

	checkStats();
}

void Pet::Sleep(float amount)
{
	hunger -= (amount * 5);
	thirst -= (amount * 3);
	sleepiness += (amount * 10);
	happiness -= (amount * 10);

	checkStats();
}

void Pet::Playing(float amount)
{
	hunger -= (amount * 8);
	thirst -= (amount * 5);
	sleepiness -= (amount * 6);
	happiness += (amount * 5);

	checkStats();
}

void Pet::WatchMovie(float amount)
{
	hunger -= (amount * 2);
	thirst -= (amount * 2);
	sleepiness -= (amount * 3);
	happiness += (amount * 10);

	checkStats();
}

void Pet::Toilet()
{
	hunger -= 5;
	thirst -= 5;
	sleepiness -= 5;
	happiness += 5;

	checkStats();
}

bool Pet::checkHealth()
{
	if (hunger == 0.0f || thirst == 0.0f || sleepiness == 0.0f || happiness == 0.0f)
	{
		return false;
	}
	else if (hunger < 10.0f || thirst < 10.0f || sleepiness < 10.0f || happiness < 10.0f)
	{
		cc.Magenta();
		cout << endl << "[" << petName << "]";
		cc.White();
		cout << " I'm dying" << endl;

		return true;
	}
	else
	{
		return true;
	}
}

void Pet::Reset()
{
	hunger = 100.0f;
	thirst = 100.0f;
	sleepiness = 100.0f;
	happiness = 100.0f;
}

void Pet::checkStats()
{
	if (hunger > 100.0f)
	{
		hunger = 100.0f;
	}

	if (hunger < 0.0f)
	{
		hunger = 0.0f;
	}

	if (thirst > 100.0f)
	{
		thirst = 100.0f;
	}

	if (thirst < 0.0f)
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
