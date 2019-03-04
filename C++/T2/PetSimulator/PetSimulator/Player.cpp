#include "Player.h"

Player::Player() :
	playerName("DEFAULT NAME")
{}

Player::~Player()
{}

void Player::setName(std::string name)
{
	playerName = name;
}

std::string Player::getName()
{
	return playerName;
}

void Player::feedingPet(Pet * p, float amount) // In Gram
{
	p->Eat(amount);
}

void Player::goForWalk(Pet * p, float distance) // In Meter
{
	p->Walk(distance);
}

void Player::goForSleep(Pet * p, float amount) // In Hour
{
	p->Sleep(amount);
}

void Player::goForPlay(Pet * p, float amount) // In Hour
{
	p->Playing(amount);
}

void Player::goForMovie(Pet * p, float amount) // In Hour
{
	p->WatchMovie(amount);
}

void Player::goForToilet(Pet * p)
{
	p->Toilet();
}
