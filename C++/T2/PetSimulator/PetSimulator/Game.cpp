#include "Manager.h"
#include "Game.h"

Game::Game() :
	manager(nullptr)
{}

Game::~Game()
{}

void Game::Start()
{
	manager = new Manager();

	// Initialize Pet and Player
	manager->Initialize();

	// Welcome Screen
	manager->showWelcomeScreen();

	// Set player name
	manager->askPlayerName();

	// Set pet name
	manager->askPetName();
}

void Game::Update()
{
	bool isRunning = true;
	// Game Loop
	while (isRunning)
	{
		// Check pet
		if (!manager->checkPet())
		{
			manager->showDeathScreen();

			// Ask player to play again
			bool decision = manager->askToPlayAgain();
			if (!decision)
			{
				isRunning = false;
				break;
			}
			else
			{
				// Reset pet stats
				manager->showResetScreen();
				continue;
			}
		}
		else
		{
			// Pause screen for player, so they can read a stat
			system("pause");
			system("cls");

			// Check day
			manager->checkDay();

			// Show commands for a player
			manager->showCommandScreen();

			// Ask player an input for command
			manager->askForCommand();

			// Show Pet Stats
			manager->showPetStats();
		}
	}

	manager->showEndScreen();
}

void Game::Terminate()
{
	// Delete pointers
	manager->Terminate();
	delete manager;
}
