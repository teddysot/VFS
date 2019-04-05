// Spawners.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <vector>
#include <time.h>
#include <stdlib.h>
#include <cmath>
#include "Header.h"

const int NUM_CYCLES = 100;

using namespace std;

int ComputeCollisions(vector<entity>& spawnedEntities)
{
	int total = 0;
	for (unsigned int i = 0; i < (spawnedEntities.size() - 1); ++i)
	{
		for (unsigned int j = i + 1; j < spawnedEntities.size(); ++j)
		{
			if (spawnedEntities[i].isOverlapping(spawnedEntities[j]))
			{
				++total;
			}
		}
	}
	return total;
}

int TriangleNumber(int input)
{
	if (input <= 0) return 0;
	return input * (input + 1) / 2;
}


//----------------------- Main Function  (Subject to change) -----------------------------
// In this code, I did not check to make sure that the entities are within the spawn volume.
// You should ensure they do.
int main()
{

	// Lightweight testing
	box rectangle(0.f, 0.f, 10.f, 15.f);
	entity testA(0.f, 0.f, 3.f);
	entity testB(7.f, 0.f, 4.f);

	// overlapping spheres
	cout << testA.isOverlapping(testB) << " == true " << endl;

	// move B outside
	testB = entity(7.1f, 0.f, 4.f);
	cout << !testA.isOverlapping(testB) << " == true " << endl;

	// entity center is within
	cout << rectangle.isEntityOverlapping(testB) << " == true " << endl;

	// entity center is outside but within radius
	testB = entity(11.f, 0.f, 5.0f);
	cout << rectangle.isEntityOverlapping(testB) << " == true " << endl;

	// entity center is outside and outside radius
	testB = entity(15.f, 0.f, 4.0f);
	cout << !rectangle.isEntityOverlapping(testB) << " == true " << endl;

	// entity center is outside (above) and outside radius
	testB = entity(9.f, 20.f, 4.0f);
	cout << !rectangle.isEntityOverlapping(testB) << " == true " << endl;

	// entity center is outside (below) and outside radius
	testB = entity(20.f, -19.1f, 4.0f);
	cout << !rectangle.isEntityOverlapping(testB) << " == true " << endl;

	// Testing Spawn Implementation
	double totalComputeTime = 0.0;
	int totalCollisions = 0;
	int totalPotentialCollisions = 0;
	int totalSpawned = 0;

	for (int n = 0; n < NUM_CYCLES; n++)
	{
		float center_x = 100.f*((float)rand()) / (float)RAND_MAX;
		float center_y = 100.f*((float)rand()) / (float)RAND_MAX;
		float halfWidth = 40.f*((float)rand()) / (float)RAND_MAX + 10.f;
		float halfHeight = 40.f*((float)rand()) / (float)RAND_MAX + 10.f;
		float fixedRadius = 10.f*((float)rand()) / (float)RAND_MAX + 1.0f;

		int numberToSpawn = (int)round(halfWidth*halfHeight / (3.f*fixedRadius*fixedRadius));	// ~25% full

		vector<entity> spawnedEntities;

		// try to compute the time for just this function.
		clock_t startTime = clock();
		spawn(box(center_x, center_y, halfWidth, halfHeight), numberToSpawn, fixedRadius, spawnedEntities);
		totalComputeTime += double(clock() - startTime);

		int numCollisions = ComputeCollisions(spawnedEntities);

		totalSpawned += numberToSpawn;
		totalPotentialCollisions += TriangleNumber(numberToSpawn - 1);
		totalCollisions += numCollisions;
	}

	cout << "Average Compute Time per entity :" << totalComputeTime / (double)CLOCKS_PER_SEC / totalSpawned << " clocks." << endl;
	cout << "Percent Chance of Collision : " << 100.f * ((float)totalCollisions / (float)totalPotentialCollisions) << endl;

}


// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
