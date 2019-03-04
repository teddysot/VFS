#pragma once
#include "Pet.h"
#include <string>

class Player
{
public:
	Player();
	~Player();

	void setName(std::string name);

	std::string getName();

	void feedingPet(Pet* p, float amount);
	void goForWalk(Pet* p, float distance);
	void goForSleep(Pet* p, float amount);
	void goForPlay(Pet* p, float amount);
	void goForMovie(Pet* p, float amount);
	void goForToilet(Pet* p);

private:
	std::string playerName;
};