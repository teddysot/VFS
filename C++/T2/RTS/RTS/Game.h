#pragma once
#include "Singleton.h"

#include "PlayerAI.h"
#include "PlayerHuman.h"

class Game : public Singleton<Game>
{
public:
	void Run();

	PlayerHuman mPlayerHuman;
	PlayerAI mPlayerAI;
};