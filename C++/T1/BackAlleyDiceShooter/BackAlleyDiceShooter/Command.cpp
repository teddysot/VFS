#include "Command.h"

using namespace std;

void Command::checkCommands(Player * p, int command)
{
	// Check command from player intput
	while (cin.fail() || command < 1 || command > 24)
	{
		// Print out error
		cout << "[HOST] Invalid command!\n";
		cout << "[HOST] Choose your bet again: ";

		// https://stackoverflow.com/questions/5864540/infinite-loop-with-cin-when-typing-string-while-a-number-is-expected
		// clear error state
		cin.clear();
		// discard 'bad' character(s)
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

		cin >> command;
	}

	Host().askForBetAmount(p);

	switch (command)
	{
		// Big
	case Big:
		cout << endl;
		cout << "[" << p->getName() << "]" << "I choose Big\n\n";
		Betting().bigBet(p);
		break;

		// Small
	case Small:
		cout << "[" << p->getName() << "]" << "I choose Small\n\n";
		Betting().smallBet(p);
		break;

		// Odd
	case Odd:
		cout << "[" << p->getName() << "]" << "I choose Odd\n\n";
		Betting().oddBet(p);
		break;

		// Even
	case Even:
		cout << "[" << p->getName() << "]" << "I choose Even\n\n";
		Betting().evenBet(p);
		break;

		// Triples
	case All1s:
		cout << "[" << p->getName() << "]" << "I choose All 1s\n\n";
		Betting().allTrippleBet(p, 1);
		break;
	case All2s:
		cout << "[" << p->getName() << "]" << "I choose All 2s\n\n";
		Betting().allTrippleBet(p, 2);
		break;
	case All3s:
		cout << "[" << p->getName() << "]" << "I choose All 3s\n\n";
		Betting().allTrippleBet(p, 3);
		break;
	case All4s:
		cout << "[" << p->getName() << "]" << "I choose All 4s\n\n";
		Betting().allTrippleBet(p, 4);
		break;
	case All5s:
		cout << "[" << p->getName() << "]" << "I choose All 5s\n\n";
		Betting().allTrippleBet(p, 5);
		break;
	case All6s:
		cout << "[" << p->getName() << "]" << "I choose All 6s\n\n";
		Betting().allTrippleBet(p, 6);
		break;

		// Doubles
	case Double1s:
		cout << "[" << p->getName() << "]" << "I choose Double 1s\n\n";
		Betting().allDoubleBet(p, 1);
		break;
	case Double2s:
		cout << "[" << p->getName() << "]" << "I choose Double 2s\n\n";
		Betting().allDoubleBet(p, 2);
		break;
	case Double3s:
		cout << "[" << p->getName() << "]" << "I choose Double 3s\n\n";
		Betting().allDoubleBet(p, 3);
		break;
	case Double4s:
		cout << "[" << p->getName() << "]" << "I choose Double 4s\n\n";
		Betting().allDoubleBet(p, 4);
		break;
	case Double5s:
		cout << "[" << p->getName() << "]" << "I choose Double 5s\n\n";
		Betting().allDoubleBet(p, 5);
		break;
	case Double6s:
		cout << "[" << p->getName() << "]" << "I choose Double 6s\n\n";
		Betting().allDoubleBet(p, 6);
		break;

		// Any Triple
	case Anytriples:
		cout << "[" << p->getName() << "]" << "I choose Any Triples\n\n";
		Betting().anyTrippleBet(p);
		break;

		// Sums
	case fourOrSeventeen:
		cout << "[" << p->getName() << "]" << "I choose 4 or 17\n\n";
		Betting().fourOrSeventeenBet(p);
		break;
	case fiveOrSixteen:
		cout << "[" << p->getName() << "]" << "I choose 5 or 16\n\n";
		Betting().fiveOrSixteenBet(p);
		break;
	case sixOrFifteen:
		cout << "[" << p->getName() << "]" << "I choose 6 or 15\n\n";
		Betting().sixOrfifteenBet(p);
		break;
	case sevenOrFourteen:
		cout << "[" << p->getName() << "]" << "I choose 7 or 14\n\n";
		Betting().sevenOrfourteenBet(p);
		break;
	case eightOrThirteen:
		cout << "[" << p->getName() << "]" << "I choose 8 or 13\n\n";
		Betting().eightOrthirteenBet(p);
		break;
	case nineOrTwelve:
		cout << "[" << p->getName() << "]" << "I choose 9 or 12\n\n";
		Betting().nineOrtwelveBet(p);
		break;
	case tenOrEleven:
		cout << "[" << p->getName() << "]" << "I choose 10 or 11\n\n";
		Betting().tenOrelevenBet(p);
		break;
	default:
		cout << "[HOST] Invalid command!" << endl;
		break;
	}

	system("pause");
}
