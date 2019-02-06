#pragma once
#include "Common.h"

#include "Player.h"

class Host
{
public:
	Host() {}
	~Host() {}

	std::string askPlayerName();
	void askForBetType(Player* p);
	void askForBetAmount(Player* p);

	void showCommandScreen(Player* p);
	void showBalance(Player* p);
	void showWonScreen();
	void showLostScreen();
	void showResetBalanceScreen();
};