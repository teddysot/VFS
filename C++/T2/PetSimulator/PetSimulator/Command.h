#pragma once
#include "Pet.h"
#include "Player.h"

class Command
{
public:
	void checkCommand(int command, Player* player, Pet* p);
private:
	enum Commands
	{
		Feed = 1,
		Walk,
		Sleep,
		Play,
		Movie,
		Toilet
	};
};