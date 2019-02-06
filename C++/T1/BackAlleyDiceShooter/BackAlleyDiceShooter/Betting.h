#pragma once
#include "Common.h"

#include "Dice.h"
#include "Player.h"

enum betType
{
	Big = 1,
	Small = 2,
	Odd = 3,
	Even = 4,
	All1s = 5,
	All2s = 6,
	All3s = 7,
	All4s = 8,
	All5s = 9,
	All6s = 10,
	Double1s = 11,
	Double2s = 12,
	Double3s = 13,
	Double4s = 14,
	Double5s = 15,
	Double6s = 16,
	Anytriples = 17,
	fourOrSeventeen = 18,
	fiveOrSixteen = 19,
	sixOrFifteen = 20,
	sevenOrFourteen = 21,
	eightOrThirteen = 22,
	nineOrTwelve = 23,
	tenOrEleven = 24
};

class Betting
{
public:
	Betting();
	~Betting();

	const int getTripple();
	const int getDouble();

	void setTripple(int t);
	void setDouble(int d);

	// Bet Functions
	void bigBet(Player* p);
	void smallBet(Player* p);
	void oddBet(Player* p);
	void evenBet(Player* p);
	void fourOrSeventeenBet(Player* p);
	void fiveOrSixteenBet(Player* p);
	void sixOrfifteenBet(Player* p);
	void sevenOrfourteenBet(Player* p);
	void eightOrthirteenBet(Player* p);
	void nineOrtwelveBet(Player* p);
	void tenOrelevenBet(Player* p);
	void allTrippleBet(Player* p, int t);
	void anyTrippleBet(Player* p);
	void allDoubleBet(Player* p, int d);

	void deleteDice();

private:
	// Initialize random object for dice
	void rollThreeDices();

	// Dices
	Dice* dices;

	// Store bet values
	int nTriple;
	int nDouble;
	int diceResultSum;
};