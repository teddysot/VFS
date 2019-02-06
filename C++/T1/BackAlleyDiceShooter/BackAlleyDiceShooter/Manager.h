#pragma once
#include "Common.h"

#include "Player.h"

class Manager
{
public:
	void showWelcomeScreen();
	void showEndScreen();

	void startGame(Player* p);

	bool checkWin(Player* p);
	bool checkLose(Player* p);

	std::string askToPlayAgain(Player* p);
};