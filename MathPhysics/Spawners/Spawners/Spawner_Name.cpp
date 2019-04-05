#include "pch.h"

#include "Header.h"
#include <time.h>
#include <stdlib.h>
#include <iostream>
#include <cmath>
#pragma once

using namespace std;



//----------------------- Implement this method -----------------------------
// Spawn 'num' entities in the spawnArea. All entities will have the same size given by the radius
// spawnArea is a AABB with x and y at the center. This method returns the vector of entities using the
// 'spawned' parameter. Your goal is to ensure the correct number of entities are spawned, and that all
// entities are not overlapping or outside the spawnArea. Also, entities should not overlap with eachother.
void spawn(box&& spawnArea, int num, float radiusSize, vector<entity>& spawned)
{
	/* your code here */
	spawned.push_back(entity(spawnArea.x(), spawnArea.y(), radiusSize));
	//You may modify these 4 lines as well
	
	// Random position
	float center_x = 1* ((float)rand()) / (float)RAND_MAX;
	float center_y = 1* ((float)rand()) / (float)RAND_MAX;

	// Create entity
	entity* e = new entity(center_x, center_y, radiusSize);

	for (int i = 0; i < num; i++)
	{
		// Loop to check all entities
		for (int j = 0; j < spawned.size(); j++)
		{
			// If it's overlapped either any entity or box return and do another cycle
			if (e->isOverlapping(spawned[j]) || spawnArea.isEntityOverlapping(*e))
			{
				cout << "Overlapped!" << endl;
				return;
			}
			else
			{
				// If it's not overlapped add to the spawned list
				cout << "Spawned: " << spawned.size() << endl;
				spawned.push_back(*e);
			}
		}
	}
}



