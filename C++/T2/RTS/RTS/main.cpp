#include "Singleton.h"
#include "Game.h"

Game* Singleton<Game>::mInstance = nullptr;

int main()
{
	Game::getInstance().Run();
}