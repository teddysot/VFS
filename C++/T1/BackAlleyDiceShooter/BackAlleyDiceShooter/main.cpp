#include "Host.h"
#include "Manager.h"

using namespace std;

int main()
{
	Player* p = new Player();
	// Welcome Screen
	Manager().showWelcomeScreen();

	// Start the game
	Manager().startGame(p);

	// Game loop
	bool isRunning = true;
	while (isRunning)
	{
		// Check Lose Condition
		if (Manager().checkLose(p))
		{
			// Print lost screen
			Host().showLostScreen();

			// Ask player decision
			string decision = Manager().askToPlayAgain(p);
			if (decision == "n" || decision == "N")
			{
				isRunning = false;
				break;
			}
			else
			{
				// Print reset balance screen
				Host().showResetBalanceScreen();
				continue;
			}

		}
		else if (Manager().checkWin(p))
		{
			// Check Win condition
			Host().showWonScreen();

			string decision = Manager().askToPlayAgain(p);
			if (decision == "n" || decision == "N")
			{
				isRunning = true;
				break;
			}
			else
			{
				Host().showResetBalanceScreen();
				continue;

			}
		}
		else
		{
			// Continuing Game
			Host().showCommandScreen(p);
			Host().showBalance(p);
			Host().askForBetType(p);
		}
		// Show Balance
		Host().showBalance(p);
	}
	// Show End Screen
	Manager().showEndScreen();
	return 0;
}