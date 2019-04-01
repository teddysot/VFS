#pragma once

#include "Player.h"

class PlayerHuman : public Player
{
public:
	virtual void Run();
	Army GetArmy();
	Army mHumanArmy;
};