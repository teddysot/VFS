#pragma once
#include "Common.h"

class Player
{
public:
	// Player Constructor
	Player();
	~Player();

	// Get Functions
	const std::string getName();
	const int getBalance();
	const int getBetAmount();
	const int getChoice();

	// Set Functions
	void setName(std::string pName);
	void setMoney(int amount);
	void setBetAmount(int amount);
	void setChoice(int choice);

	// Reset Balance
	void resetMoney();

private:
	// Player members
	std::string playerName;
	int playerBalance;
	int playerBetAmount;
	int playerChoice;
};