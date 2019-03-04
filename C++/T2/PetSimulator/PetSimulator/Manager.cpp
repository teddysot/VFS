#include <iostream>

#include "ConsoleColor.h"
#include "Manager.h"

using namespace std;

Manager::Manager() :
	counter(0),
	dayCount(0),
	totalDayCount(1),
	command(nullptr),
	player(nullptr),
	pet(nullptr)
{}

Manager::~Manager()
{}

void Manager::Initialize()
{
	command = new Command();
	pet = new Pet();
	player = new Player();
}

void Manager::Terminate()
{
	delete command;
	delete pet;
	delete player;
}

void Manager::showWelcomeScreen()
{
	ConsoleColor cc;
	cc.Blue();
	cout << "=========================================================================\n\n\n";
	cc.Red();
	cout << "               Welcome to Tamagottagettemall Pet Simulator              \n\n\n\n\n";
	cc.Green();
	cout << "                     Press any key to start the game                    \n\n";
	cc.Blue();
	cout << "=========================================================================\n";
	cc.White();
	system("pause");
}

void Manager::showEndScreen()
{
	ConsoleColor cc;
	cc.Blue();
	cout << "=========================================================================\n\n\n";
	cc.Red();
	cout << "                                Good Bye!              \n\n\n\n\n";
	cc.Green();
	cout << "                     Press any key to exit the game                    \n\n";
	cc.Blue();
	cout << "=========================================================================\n";
	cc.White();
	system("pause");
}

void Manager::showDeathScreen()
{
	ConsoleColor cc;
	cc.Yellow();
	cout << "[GAME] ";
	cc.White();
	cout << pet->getName() << " Died!\n";
}

void Manager::showResetScreen()
{
	ConsoleColor cc;
	cc.Yellow();
	cout << "[GAME] ";
	cc.White();
	cout << pet->getName() << " stats has been reset\n";
	
	// Reset all stats
	pet->Reset();
	counter = 0;
	dayCount = 0;
	totalDayCount = 1;
}

void Manager::showCommandScreen()
{
	ConsoleColor cc;
	cc.Yellow();
	cout << "[GAME] ";
	cc.White();
	cout << "Hi " << player->getName() << ", Welcome to the game\n";
	cc.Yellow();
	cout << "[GAME] ";
	cc.White();
	cout << "What would you like to do today?\n";
	cout << "1. Feed " << pet->getName() << endl;
	cout << "2. Walk " << pet->getName() << endl;
	cout << "3. Sleep " << pet->getName() << endl;
	cout << "4. Play " << pet->getName() << endl;
	cout << "5. Movie " << pet->getName() << endl;
	cout << "6. Toilet " << pet->getName() << endl;
}

void Manager::showPetStats()
{
	ConsoleColor cc;
	cc.Magenta();
	cout << "[" << pet->getName() << "] ";
	cc.White();
	cout << "Stats: \n";
	cout << "Hunger: " << pet->getHunger() << endl;
	cout << "Thirst: " << pet->getThirst() << endl;
	cout << "Sleepiness: " << pet->getSleepiness() << endl;
	cout << "Happiness: " << pet->getHappiness() << endl;
	cout << endl;
}

// Keep track of day
void Manager::checkDay()
{
	if (counter != 2)
	{
		counter++;
	}
	else if (counter == 2)
	{
		dayCount++;
		counter = 0;
	}

	if (dayCount > 6)
	{
		dayCount = 0;
	}

	ConsoleColor cc;
	cc.Yellow();
	cout << "[Game] ";
	cc.White();
	cout << "Day ";
	cc.Red();
	cout << totalDayCount << endl;
	cc.White();

	// Print current day
	switch (dayCount)
	{
	case Monday:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Today is ";
		cc.DarkYellow();
		cout << "Monday\n";
		cc.White();
		break;
	case Tuesday:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Today is ";
		cc.DarkMagenta();
		cout << "Tuesday\n";
		cc.White();
		break;
	case Wednesday:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Today is ";
		cc.DarkGreen();
		cout << "Wednesday\n";
		cc.White();
		break;
	case Thursday:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Today is ";
		cc.DarkRed();
		cout << "Thursday\n";
		cc.White();
		break;
	case Friday:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Today is ";
		cc.Cyan();
		cout << "Cyan\n";
		cc.White();
		break;
	case Saturday:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Today is ";
		cc.Magenta();
		cout << "Saturday\n";
		cc.White();
		break;
	case Sunday:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Today is ";
		cc.Red();
		cout << "Sunday\n";
		cc.White();
		break;
	}

	totalDayCount++;
}

bool Manager::checkPet()
{
	return pet->checkHealth();
}

void Manager::askPlayerName()
{
	ConsoleColor cc;
	cc.Yellow();
	cout << "[Game] ";
	cc.White();
	cout << "Enter Player Name: ";

	std::string name;
	cin >> name;
	player->setName(name);
}

void Manager::askPetName()
{
	ConsoleColor cc;
	cc.Yellow();
	cout << "[Game] ";
	cc.White();
	cout << "Enter Pet Name: ";

	std::string name;
	cin >> name;
	pet->setName(name);
}

void Manager::askForCommand()
{
	ConsoleColor cc;
	cc.Yellow();
	cout << "[Game] ";
	cc.White();
	cout << "Enter your choice: ";

	int choice;
	cin >> choice;
	
	command->checkCommand(choice, player, pet);
}

bool Manager::askToPlayAgain()
{
	ConsoleColor cc;
	cc.Yellow();
	cout << "[Game] ";
	cc.White();
	cout << "Do you want to play again?\n";
	cout << "Y - Yes | N - No\n";

	cc.Yellow();
	cout << "[Game] ";
	cc.White();
	cout << "Enter your choice: ";

	char choice;
	cin >> choice;
	
	if (choice == 'Y' || choice == 'y')
	{
		return true;
	}
	else
	{
		return false;
	}
}
