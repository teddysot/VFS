// PG14 Assignment 3 : Collisions
// Your Name here
#include "pch.h"
#include "Collision.h"

// Part A : Sampling Geometry
//-------------------------------------
//Hint : check against leftmost side, rightmost side, top and bottom
bool AABB::isInside(float x, float y)
{
	/* Your Code Here */
	if (mx >= x - halfWidth
		&& my >= y - halfHeight
		&& x <= x + halfWidth
		&& y <= y + halfHeight)
	{
		return true;
	}

	return false;
}

//-------------------------------------
//Hint : check the distance from the center of the sphere to the point against the radius of the sphere
bool Sphere::isInside(float x, float y)
{
	/* Your Code Here */
	float v = sqrt(((mx - x) * (mx - x)) + ((my - y) * (my - y)));

	if (v >= radius)
	{
		return true;
	}

	return false;
}

//-------------------------------------
//Hint : the dot product can help you compute the shortest distance from a point to the surface of the plane. 
bool Plane::isInside(float x, float y)
{
	/* Your Code Here */
	float deltaX = x - mx;
	float deltaY = y - my;
	float dis = (x * nx) + (y * ny);

	if (dis == 0.0f)
	{
		return true;
	}

	return false;
}


//Part B : Overlap Tests
//Hint : Deal with each axis separately. If the leftmost side of one box is further to the right, of the rightmost side of another box, then they are definitely not overlapping
//-------------------------------------
bool OverlapTest::Test(AABB* obja, AABB* objb)
{
	/* Your Code Here */

	return obja->isInside(objb->getX(), objb->getY());
}

//-------------------------------------
//Hint : Treat each side of the box as a plane. Use the plane-sphere overlap test on each side. 
bool OverlapTest::Test(AABB* obja, Sphere* objb)
{
	/* Your Code Here */

	return obja->isInside(objb->getX(), objb->getY());;
}

//-------------------------------------
//Hint : You only really need to check if any corner is inside the plane.
bool OverlapTest::Test(AABB* obja, Plane* objb)
{
	/* Your Code Here */

	return obja->isInside(objb->getX(), objb->getY());;
}

//-------------------------------------
//Hint : Compare the center to center distances with the combined radii
bool OverlapTest::Test(Sphere* obja, Sphere* objb)
{
	/* Your Code Here */

	return obja->isInside(objb->getX(), objb->getY());;
}

//-------------------------------------
//Hint : Is the shortest distance from the center of the sphere to the plane shorter than the radius of the sphere?
bool OverlapTest::Test(Sphere* obja, Plane* objb)
{
	/* Your Code Here */

	return obja->isInside(objb->getX(), objb->getY());;
}

//-------------------------------------
//Hint : If the surfaces of two planes are not perfectly parallel, then they will definitely intersect somewhere.
bool OverlapTest::Test(Plane* obja, Plane* objb)
{
	/* Your Code Here */

	return obja->isInside(objb->getX(), objb->getY());;
}
