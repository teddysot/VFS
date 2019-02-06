#include "Manager.h"
#include "Host.h"

using namespace std;

void Manager::showWelcomeScreen()
{
	system("cls");
	cout << "=========================================================================\n\n\n";
	cout << "                    Welcome to Back Alley Dice Shooter\n\n\n\n\n";
	cout << "                     Press any key to start the game\n\n";
	cout << "=========================================================================\n";
	system("pause");
}

void Manager::showEndScreen()
{
	system("cls");
	cout << "=========================================================================\n\n\n";
	cout << "                                Good Bye!\n\n\n\n\n";
	cout << "                     Press any key to exit the game\n\n";
	cout << "=========================================================================\n";
	system("pause");
}

void Manager::startGame(Player* p)
{
	system("cls");
	string pName = Host().askPlayerName();
	p->setName(pName);
}

bool Manager::checkWin(Player* p)
{
	// Check player balance
	if (p->getBalance() >= 100000)
	{
		return true;
	}
	return false;
}

bool Manager::checkLose(Player* p)
{
	// Check player balance
	if (p->getBalance() <= 0)
	{
		return true;
	}
	return false;
}

std::string Manager::askToPlayAgain(Player* p)
{
	string input = "";

	while (input != "y" || input != "Y" || input != "n" || input != "N")
	{
		cout << "\n\n[HOST] Do you want to play again?\n";
		cout << "Y - Yes | N - No\n";
		// clear error state
		cin.clear();
		// discard 'bad' character(s)
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		cin >> input;

		if (input == "y" || input == "Y" || input == "n" || input == "N")
		{
			p->resetMoney();
			break;
		}
		else
		{
			cout << "[HOST] Invalid Input!";
		}
	}
	return input;
}
