#pragma once

#include "Manager.h"

class Game
{
public:
	Game();
	~Game();

	void Start();
	void Update();
	void Terminate();

private:
	Manager* manager;
};