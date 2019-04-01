#include "PlayerAI.h"

#include <random>
#include <chrono>
#include <thread>

#include <iostream>

using namespace std;

void PlayerAI::Run()
{
	cout << "-------------------------" << endl;
	cout << "-------------------------" << endl;
	cout << "       AI Turn" << endl;
	cout << "-------------------------" << endl;
	cout << "-------------------------" << endl << endl;

	cout << "-------------------------" << endl;
	cout << "Commands: " << endl;
	cout << "1.Create Unit\n2.Attack" << endl;
	cout << "-------------------------" << endl;

	
	// Pause for 3 seconds
	this_thread::sleep_for(chrono::seconds(3));

	// Random number between 1 and 2
	random_device rd;
	mt19937 mt(rd());
	uniform_int_distribution<int> dist(1, 2);
	int randomNo = dist(rd);

	cout << "Choose: " << randomNo << endl;

	if (randomNo == 1)
	{
		cout << "-------------------------" << endl;
		cout << "Unit Types: " << endl;
		cout << "1.Normal\n2.Fire\n3.Water\n4.Special" << endl;
		cout << "-------------------------" << endl;

		// Pause for 3 seconds
		this_thread::sleep_for(chrono::seconds(3));

		// Random number between 1 and 4
		random_device rd2;
		mt19937 mt(rd2());
		uniform_int_distribution<int> dist2(1, 4);
		int randomType = dist2(rd2);

		cout << "Choose: " << randomType << endl;

		switch (randomType)
		{
		case Normal:
			mAIArmy.CreateUnit(Normal);
			break;
		case Fire:
			mAIArmy.CreateUnit(Fire);
			break;
		case Water:
			mAIArmy.CreateUnit(Water);
			break;
		case Special:
			mAIArmy.CreateUnit(Special);
			break;
		default:
			mAIArmy.CreateUnit(Normal);
			break;
		}
	}
	else if (randomNo == 2)
	{
		for (int i = 0; i < mAIArmy.mUnits.size(); i++)
		{
			PlayerAI mPlayerHuman;
			if (mPlayerHuman.GetArmy().mUnits.size() == 0)
			{
				cout << "Cannot attack, no unit" << endl;
				break;
			}
			mAIArmy.mUnits[i]->Attack(mPlayerHuman.GetArmy().mUnits[0]);
		}
	}
}

Army PlayerAI::GetArmy()
{
	return mAIArmy;
}
