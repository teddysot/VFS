#include "Host.h"
#include "Command.h"

using namespace std;

std::string Host::askPlayerName()
{
	// Prompt up input for player
	cout << "[HOST] Enter your name: ";
	string pName;
	cin >> pName;
	
	return pName;
}

void Host::askForBetType(Player* p)
{
	// Prompt up input for player
	cout << "\n\n[HOST] Choose your bet: ";
	int input;
	cin >> input;

	while (cin.fail())
	{
		cout << "[HOST] Invalid Command!\n";
		cout << "[HOST] Choose your bet again: ";
		// clear error state
		cin.clear();
		// discard 'bad' character(s)
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		cin >> input;
	}

	Command().checkCommands(p, input);
}

void Host::askForBetAmount(Player* p)
{
	cout << "[HOST] Enter your bet amount: ";

	// Initialize variable
	int playerInput;

	cin >> playerInput;

	while (cin.fail())
	{
		// Print out error
		cout << "[HOST] It is not a number\n";
		cout << "[HOST] Enter your bet amount again: ";
		// clear error state
		cin.clear();
		// discard 'bad' character(s)
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		cin >> playerInput;
	}

	while (playerInput > p->getBalance())
	{
		// Print out error
		cout << "[HOST] You don't have enough balance\n";
		cout << "[HOST] Enter your bet amount again: ";

		cin >> playerInput;

		while (cin.fail())
		{
			// Print out error
			cout << "[HOST] It is not a number\n";
			cout << "[HOST] Enter your bet amount again: ";
			cin.clear();
			cin >> playerInput;
		}
	}

	p->setBetAmount(playerInput);
}

void Host::showCommandScreen(Player* p)
{
	system("cls");

	cout << "Player Name: " << p->getName() << endl;
	cout << "=========================================================================\n";
	cout << "Bet Types:\n\n";
	cout << "1. Big             2. Small        3. Odd          4. Even\n";
	cout << "5. All 1s          6. All 2s       7. All 3s       8. All 4s\n";
	cout << "9. All 5s          10. All 6s      11. Double 1s   12. Double 2s\n";
	cout << "13. Double 3s      14. Double 4s   15. Double 5s   16. Double 6s\n";
	cout << "17. Any triples    18. 4 or 17     19. 5 or 16     20. 6 or 15\n";
	cout << "21. 7 or 14        22. 8 or 13     23. 9 or 12     24. 10 or 11\n";
	cout << "=========================================================================\n";
}

void Host::showBalance(Player* p)
{
	cout << "[HOST] Your balance: " << p->getBalance() << endl;
}

void Host::showWonScreen()
{
	cout << "[HOST] You exceeded our limit now.\n";
	cout << "[HOST] Sorry, You have to leave\n";
}

void Host::showLostScreen()
{
	cout << "[HOSt] Sorry, You are broke now.\n";
}

void Host::showResetBalanceScreen()
{
	cout << "\n[HOST] Your balance has been reset to $200. \n";
	
	system("pause");
}
