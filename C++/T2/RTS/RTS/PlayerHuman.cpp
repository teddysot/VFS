#include "PlayerHuman.h"
#include "PlayerAI.h"

#include <iostream>

using namespace std;

void PlayerHuman::Run()
{
	cout << "-------------------------" << endl;
	cout << "-------------------------" << endl;
	cout << "       Player Turn" << endl;
	cout << "-------------------------" << endl;
	cout << "-------------------------" << endl << endl;

	cout << "-------------------------" << endl;
	cout << "Commands: " << endl;
	cout << "1.Create Unit\n2.Attack" << endl;
	cout << "-------------------------" << endl;

	int userInput;
	cout << "Choose: ";
	cin >> userInput;

	if (userInput == 1)
	{
		cout << "-------------------------" << endl;
		cout << "Unit Types: " << endl;
		cout << "1.Normal\n2.Fire\n3.Water\n4.Special" << endl;
		cout << "-------------------------" << endl;

		int inputType;
		cout << "Choose: ";
		cin >> inputType;
		switch (inputType)
		{
		case Normal:
			mHumanArmy.CreateUnit(Normal);
			break;
		case Fire:
			mHumanArmy.CreateUnit(Fire);
			break;
		case Water:
			mHumanArmy.CreateUnit(Water);
			break;
		case Special:
			mHumanArmy.CreateUnit(Special);
			break;
		default:
			mHumanArmy.CreateUnit(Normal);
			break;
		}
	}
	else if (userInput == 2)
	{
		for (int i = 0; i < mHumanArmy.mUnits.size(); i++)
		{
			PlayerAI mPlayerAI;
			if (mPlayerAI.GetArmy().mUnits.size() == 0)
			{
				break;
			}
			mHumanArmy.mUnits[i]->Attack(mPlayerAI.GetArmy().mUnits[0]);
		}
	}
}

Army PlayerHuman::GetArmy()
{
	return mHumanArmy;
}
