#include "Dice.h"
#include <random>

Dice::Dice()
{
	dice = NULL;;
}

Dice::~Dice()
{}

const int Dice::getDiceValue()
{
	return dice;
}

int Dice::nRandom()
{
	// https://stackoverflow.com/questions/13445688/how-to-generate-a-random-number-in-c
	std::mt19937 rng;
	rng.seed(std::random_device()());

	// Random from 1 to 7
	std::uniform_int_distribution<std::mt19937::result_type> dist(1, 7);

	return dist(rng);
}

int Dice::diceRoll()
{
	dice = nRandom();

	return dice;
}
