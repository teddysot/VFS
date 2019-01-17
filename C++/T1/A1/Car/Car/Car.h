/**
	VFS Intro to C++
	Purpose: Declares car class for assignment

	@class Intro to Programming in C++
	@version 1.1
*/

#pragma once

class Car
{
public:

	Car();											// constructor
	~Car();											// destructor

	void TurnKeyToStart();							// start the engine
	void TurnKeyToStop();							// stop the engine

	void ShiftGearUp();								// move car into a higher gear
	void ShiftGearDown();							// move car into a lower gear

	void AcceleratorPeddleDown(float speedDelta);			// increase the speed
	void AcceleratorPeddleReleased(float speedDelta);		// decrease the speed

	void HornPressed();								// make a noise
	void HornReleased();							// stop making a noise

private:

	bool mRunning;					// is the engine running?
	int mGear;						// what gear is the car in?	
	float mSpeed;					// speed of the car
	bool mNoise;					// is the car making noise?
};
