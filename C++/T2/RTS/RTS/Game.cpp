#include "Game.h"

void Game::Run()
{
	while (true)
	{
		mPlayerHuman.Run();
		mPlayerAI.Run();
	}
}
