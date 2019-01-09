#include "Car.h"

using namespace std;

int main()
{
	Car c;

	c.TurnKeyToStart();

	c.ShiftGearUp();
	c.ShiftGearUp();
	c.ShiftGearUp();

	c.ShiftGearDown();

	c.AcceleratorPeddleDown(2.0f);

	c.HornPressed();
	c.HornReleased();

	c.TurnKeyToStop();

	return 0;
}