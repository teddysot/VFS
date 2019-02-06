#pragma once
#include "Common.h"

#include "Betting.h"
#include "Host.h"
#include "Player.h"

class Command
{
public:
	Command() {}
	~Command() {}

	void checkCommands(Player* p, int command);
};