#pragma once
#include "Command.h"
#include "Player.h"
#include "Pet.h"

class Manager
{
public:
	Manager();
	~Manager();

	void Initialize();
	void Terminate();

	void showWelcomeScreen();
	void showEndScreen();
	void showDeathScreen();
	void showResetScreen();
	void showCommandScreen();
	void showPetStats();

	void checkDay();

	bool checkPet();

	void askPlayerName();
	void askPetName();
	void askForCommand();

	bool askToPlayAgain();

private:
	// Day in a week
	enum Days
	{
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday
	};

	// Counting Day of a game
	int counter;
	int dayCount;
	int totalDayCount;
	
	Command* command;
	Player* player;
	Pet* pet;
};