#define NOMINMAX
#include "Command.h"
#include "ConsoleColor.h"

#include <iostream>

using namespace std;

void Command::checkCommand(int command, Player * player, Pet * pet)
{
	ConsoleColor cc;
	// Check command from player intput
	while (cin.fail() || command < 1 || command > 6)
	{
		// Print out error
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Invalid Command\n";

		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Choose your choice again: ";

		// https://stackoverflow.com/questions/5864540/infinite-loop-with-cin-when-typing-string-while-a-number-is-expected
		// clear error state
		cin.clear();
		// discard 'bad' character(s)
		cin.ignore(numeric_limits<streamsize>::max(), '\n');

		cin >> command;
	}

	int amount = 0;
	switch (command)
	{
	case Feed:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Enter Amount (g): ";
		
		cin >> amount;

		// Check command from player intput
		while (cin.fail())
		{
			// Print out error
			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Invalid Input\n";

			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Enter your amount again: ";

			// clear error state
			cin.clear();
			// discard 'bad' character(s)
			cin.ignore(numeric_limits<streamsize>::max(), '\n');

			cin >> amount;
		}

		cc.Cyan();
		cout << "[" << player->getName() << "]";
		cc.White();
		cout << " I choose Feed and " << amount << " g\n\n";
		player->feedingPet(pet, amount);

		break;

	case Walk:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Enter Amount (m): ";

		cin >> amount;

		// Check command from player intput
		while (cin.fail())
		{
			// Print out error
			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Invalid Input\n";

			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Enter your amount again: ";

			// clear error state
			cin.clear();
			// discard 'bad' character(s)
			cin.ignore(numeric_limits<streamsize>::max(), '\n');

			cin >> amount;
		}

		cc.Cyan();
		cout << "[" << player->getName() << "]";
		cc.White();
		cout << " I choose Walk and " << amount << " m\n\n";
		player->goForWalk(pet, amount);

		break;

	case Sleep:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Enter Amount (hr): ";

		cin >> amount;

		// Check command from player intput
		while (cin.fail())
		{
			// Print out error
			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Invalid Input\n";

			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Enter your amount again: ";

			// clear error state
			cin.clear();
			// discard 'bad' character(s)
			cin.ignore(numeric_limits<streamsize>::max(), '\n');

			cin >> amount;
		}

		cc.Cyan();
		cout << "[" << player->getName() << "]";
		cc.White();
		cout << " I choose Sleep and " << amount << " hr\n\n";
		player->goForSleep(pet, amount);

		break;

	case Play:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Enter Amount (hr): ";

		cin >> amount;

		// Check command from player intput
		while (cin.fail())
		{
			// Print out error
			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Invalid Input\n";

			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Enter your amount again: ";

			// clear error state
			cin.clear();
			// discard 'bad' character(s)
			cin.ignore(numeric_limits<streamsize>::max(), '\n');

			cin >> amount;
		}

		cc.Cyan();
		cout << "[" << player->getName() << "]";
		cc.White();
		cout << " I choose Play and " << amount << " hr\n\n";
		player->goForPlay(pet, amount);

		break;

	case Movie:
		cc.Yellow();
		cout << "[Game] ";
		cc.White();
		cout << "Enter Amount (hr): ";

		cin >> amount;

		// Check command from player intput
		while (cin.fail())
		{
			// Print out error
			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Invalid Input\n";

			cc.Yellow();
			cout << "[Game] ";
			cc.White();
			cout << "Enter your amount again: ";

			// clear error state
			cin.clear();
			// discard 'bad' character(s)
			cin.ignore(numeric_limits<streamsize>::max(), '\n');

			cin >> amount;
		}

		cc.Cyan();
		cout << "[" << player->getName() << "]";
		cc.White();
		cout << " I choose Movie and " << amount << " hr\n\n";
		player->goForPlay(pet, amount);

		break;

	case Toilet:
		cc.Cyan();
		cout << "[" << player->getName() << "]";
		cc.White();
		cout << " I choose Toilet\n\n";
		player->goForToilet(pet);
		break;
	}
}
