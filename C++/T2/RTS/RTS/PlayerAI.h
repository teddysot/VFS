#pragma once

#include "Player.h"
#include "PlayerHuman.h"

class PlayerAI : public Player
{
public:
	virtual void Run();
	Army GetArmy();
	Army mAIArmy;
};