#pragma once

class Dice
{
public:
	Dice();
	~Dice();

	// Get dice value
	const int getDiceValue() const;

	// Random int
	int nRandom();

	// Rolling dice
	int diceRoll();

private:
	int dice;
};