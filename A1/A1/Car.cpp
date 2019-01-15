/**
	VFS Intro to C++
	Purpose: Implements car class for assignment

	@class Intro to Programming in C++
	@version 1.1
*/
#include <iostream>

#include "Car.h"

Car::Car() :
	mRunning(false),
	mGear(0),
	mSpeed(0.0f),
	mNoise(false)
{
}

Car::~Car()
{
}

void Car::TurnKeyToStart()
{
	if (mRunning)
	{
		std::cout << "[TurnKeyToStart] Car is already started!" << std::endl;
		return;
	}
	mRunning = true;
	std::cout << "[TurnKeyToStart] Running: true" << std::endl;
}

void Car::TurnKeyToStop()
{
	if (!mRunning)
	{
		std::cout << "[TurnKeyToStop] Car is not started yet!" << std::endl;
		return;
	}
	mRunning = false;
	std::cout << "[TurnKeyToStop] Running: false" << std::endl;


}

void Car::ShiftGearUp()
{
	if (!mRunning)
	{
		std::cout << "[ShiftGearUp] Car is not started yet!" << std::endl;
		return;
	}

	if (mGear >= 6)
	{
		mGear = 6;
		std::cout << "[ShiftGearUp] Max GearUp! (Max: 6)" << std::endl;
		return;
	}
	mGear++;
	std::cout << "[ShiftGearUp] Gear: " << mGear << std::endl;
}

void Car::ShiftGearDown()
{
	if (!mRunning)
	{
		std::cout << "[ShiftGearDown] Car is not started yet!" << std::endl;
		return;
	}
		
	if (mGear <= 0)
		return;

	mGear--;

	std::cout << "[ShiftGearDown] Gear: " << mGear << std::endl;
}

void Car::AcceleratorPeddleDown(float speedDelta)
{
	if (!mRunning)
	{
		std::cout << "[AcceleratorPeddleDown] Car is not started yet!" << std::endl;
		return;
	}

	std::cout << "[AcceleratorPeddleDown] Initial Speed: " << mSpeed << std::endl;
	std::cout << "[AcceleratorPeddleDown] Acceleration: " << speedDelta << std::endl;
	//std::cout << "[AcceleratorPeddleDown] Assuming peddle down for 2 second" << std::endl;
	// Final Speed = Initial Speed + (Acceleration * Time)
	mSpeed = mSpeed + (speedDelta);
	std::cout << "[AcceleratorPeddleDown] Final Speed: " << mSpeed << std::endl;
}

void Car::AcceleratorPeddleReleased(float speedDelta)
{
	if (!mRunning)
	{
		std::cout << "[AcceleratorPeddleUp] Car is not started yet!" << std::endl;
		return;
	}
	
	std::cout << "[AcceleratorPeddleUp] Initial Speed: " << mSpeed << std::endl;
	std::cout << "[AcceleratorPeddleUp] Acceleration: " << speedDelta << std::endl;
	//std::cout << "[AcceleratorPeddleUp] Assuming peddle up for 2 second" << std::endl;
	// Final Speed = Initial Speed + (Acceleration * Time)
	mSpeed = mSpeed - (speedDelta);
	std::cout << "[AcceleratorPeddleUp] Final Speed: " << mSpeed << std::endl;
}

void Car::HornPressed()
{
	mNoise = true;
	std::cout << "[HornPressed] Noise: true" << std::endl;
}

void Car::HornReleased()
{
	mNoise = false;
	std::cout << "[HornReleased] Noise: false" << std::endl;
}
