#include "Game.h"
#include <iostream>

using namespace std;

int main()
{
	Game game;

	game.Start();
	game.Update();
	game.Terminate();

	return 0;
}