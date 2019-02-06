#include "Player.h"

#define START_BALANCE 200

Player::Player()
	: playerName(""),
	playerBalance(START_BALANCE),
	playerBetAmount(0),
	playerChoice(0)
{}

Player::~Player()
{
}

const std::string Player::getName()
{
	return playerName;
}

const int Player::getBalance()
{
	return playerBalance;
}

const int Player::getBetAmount()
{
	return playerBetAmount;
}

const int Player::getChoice()
{
	return playerChoice;
}

void Player::setName(std::string pName)
{
	playerName = pName;
}

void Player::setMoney(int amount)
{
	playerBalance += amount;
}

void Player::setBetAmount(int amount)
{
	playerBetAmount = amount;
}

void Player::setChoice(int choice)
{
	playerChoice = choice;
}

void Player::resetMoney()
{
	playerBalance = START_BALANCE;
}

