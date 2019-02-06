#include "Betting.h"

using namespace std;

Betting::Betting()
{
	dices = new Dice[3];
	nTriple = 0;
	nDouble = 0;
	diceResultSum = 0;
}

Betting::~Betting()
{
	delete[] dices;
}

void Betting::rollThreeDices()
{
	// Adding total dice result
	diceResultSum = 0;

	cout << "========================" << endl;
	for (int i = 0; i < 3; i++)
	{
		dices->diceRoll();
		cout << "[HOST] Rolling Dice " << i + 1 << ": " << dices->getDiceValue() << endl;
		diceResultSum += dices->getDiceValue();
	}

	cout << "[HOST] Sum: " << diceResultSum << endl;
	cout << "========================" << endl;
}

const int Betting::getTripple() const
{
	return nTriple;
}

const int Betting::getDouble() const
{
	return nDouble;
}

void Betting::setTripple(int t)
{
	nTriple = t;
}

void Betting::setDouble(int d)
{
	nDouble = d;
}

void Betting::bigBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result >= 11 && result <= 17)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the Big bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the Big bet!" << endl;
	}
}

void Betting::smallBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result >= 4 && result <= 10)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the Small bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the Small bet!" << endl;
	}
}

void Betting::oddBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result % 2 != 0)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the Odd bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the Odd bet!" << endl;
	}
}

void Betting::evenBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result % 2 == 0)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the Even bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the Even bet!" << endl;
	}
}

void Betting::fourOrSeventeenBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result == 4 || result == 17)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the 4 or 17 bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the 4 or 17 bet!" << endl;
	}
}

void Betting::fiveOrSixteenBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result == 5 || result == 16)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the 5 or 16 bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the 5 or 16 bet!" << endl;
	}
}

void Betting::sixOrfifteenBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	if (result == 6 || result == 15)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the 6 or 15 bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the 6 or 15 bet!" << endl;
	}
}

void Betting::sevenOrfourteenBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result == 7 || result == 14)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the 7 or 14 bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the 7 or 14 bet!" << endl;
	}
}

void Betting::eightOrthirteenBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result == 8 || result == 13)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the 8 or 13 bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the 8 or 13 bet!" << endl;
	}
}

void Betting::nineOrtwelveBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result == 9 || result == 12)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the 9 or 12 bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the 9 or 12 bet!" << endl;
	}
}

void Betting::tenOrelevenBet(Player* p)
{
	// Roll dices
	rollThreeDices();
	int result = diceResultSum;

	// Check the result
	if (result == 10 || result == 11)
	{
		p->setMoney(p->getBetAmount());
		cout << "[HOST] You won the 10 or 11 bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the 10 or 11 bet!" << endl;
	}
}

void Betting::allTrippleBet(Player* p, int t)
{
	// Roll dices
	rollThreeDices();

	// Check the result
	if (dices[0].getDiceValue() == t && dices[0].getDiceValue() == dices[1].getDiceValue() && dices[0].getDiceValue() == dices[2].getDiceValue())
	{
		p->setMoney(p->getBetAmount() * 180);
		cout << "[HOST] You won the Tripple bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the Triple bet!" << endl;
	}
}

void Betting::anyTrippleBet(Player* p)
{
	// Roll Dices
	rollThreeDices();

	// Check the result
	if (dices[0].getDiceValue() == dices[1].getDiceValue() && dices[0].getDiceValue() == dices[2].getDiceValue())
	{
		p->setMoney(p->getBetAmount() * 30);
		cout << "[HOST] You won the Tripple bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the Triple bet!" << endl;
	}
}

void Betting::allDoubleBet(Player* p, int d)
{
	// Roll Dices
	rollThreeDices();

	// Check the result
	if (dices[0].getDiceValue() == d 
		&& dices[0].getDiceValue() == dices[1].getDiceValue() 
		|| dices[0].getDiceValue() == d 
		&& dices[0].getDiceValue() == dices[2].getDiceValue() 
		|| dices[0].getDiceValue() == d 
		&& dices[1].getDiceValue() == dices[2].getDiceValue())
	{
		p->setMoney(p->getBetAmount() * 10);
		cout << "[HOST] You won the Double bet!" << endl;
	}
	else
	{
		p->setMoney(-(p->getBetAmount()));
		cout << "[HOST] You lost the Double bet!" << endl;
	}
}

void Betting::deleteDice()
{
	delete dices;
}
