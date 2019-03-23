// CollisionDetection.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include "Collision.h"
#include <iostream>
using namespace std;

void test_inside()
{	
	cout << endl;
	cout << "Test Point : Inside, Outside, Edge" << endl;
	cout << "----------------------------------" << endl;
	cout << "Test Axis-Aligned Bounding Box" << endl;
	AABB testBox{ 1.f, 2.f, 3.1f, 4.2f };
	cout << (testBox.isInside(0.f, 0.f) ? "true" : "false") << endl; // true
	cout << (!testBox.isInside(4.2f, 6.3f) ? "true" : "false") << endl; // false
	cout << (testBox.isInside(4.1f, 2.f) ? "true" : "false") << endl; // true

	cout << "Test Sphere" << endl;
	Sphere testSphere{ -1.f,-2.f,3.5f };
	cout << (testSphere.isInside(1.f, 1.f) ? "true" : "false") << endl;  //  true
	cout << (!testSphere.isInside(-4.6f, -2.f) ? "true" : "false") << endl;  // false
	cout << (testSphere.isInside(-1.f, 1.5f) ? "true" : "false") << endl;  // true

	cout << "Test Plane" << endl;
	Plane testPlane{ 1.f,-2.f, 0.7071f,0.7071f };
	cout << (testPlane.isInside(2.f, -2.f) ? "true" : "false") << endl;  // true
	cout << (testPlane.isInside(0.f, -2.f) ? "true" : "false") << endl;  // false
	cout << (!testPlane.isInside(1.f + 0.7071f, -2 - 0.7071f) ? "true" : "false") << endl;  // true

}

void test_collision()
{
	cout << endl;
	cout << "Test Shape vs Shape Collision" << endl;
	cout << "-----------------------------" << endl;
	cout << "AABB vs AABB" << endl;
	{
		AABB boxA{ 1.f, 2.f, 3.1f, 4.2f };
		AABB boxB{ -4.f, -3.6f, 2.0f, 1.5f };
		cout << (OverlapTest::Test(&boxA, &boxB) ? "true" : "false") << endl;
	}

	cout << "AABB vs Sphere" << endl;
	{
		AABB boxA{ 1.f, 2.f, 3.1f, 4.2f };
		Sphere sphereB{ -1.f,-2.f,3.5f };
		cout << (OverlapTest::Test(&boxA, &sphereB) ? "true" : "false") << endl;
	}

	cout << "AABB vs Plane" << endl;
	{
		AABB boxA{ 1.f, 2.f, 3.1f, 4.2f };
		Plane planeB{ 1.f,-2.f, 0.7071f,0.7071f };
		cout << (OverlapTest::Test(&boxA, &planeB) ? "true" : "false") << endl;
	}

	cout << "Sphere vs Sphere" << endl;
	{
		Sphere sphereA{ -1.f,-2.f,3.5f };
		Sphere sphereB{ -4.f,-4.f,2.f };
		cout << (OverlapTest::Test(&sphereA, &sphereB) ? "true" : "false") << endl;
	}

	cout << "Sphere vs Plane" << endl;
	{
		Sphere sphereA{ 1.f,0.f,2.0f };
		Plane planeB{ 1.f,-2.f, 0.7071f,0.7071f };
		cout << (OverlapTest::Test(&sphereA, &planeB) ? "true" : "false") << endl;
	}

	cout << "Plane vs Plane" << endl;
	{
		Plane planeA{ 1.f,-2.f, 0.7071f,0.7071f };
		Plane planeB{ 3.f, 1.f, 0.7071f,0.7071f };
		cout << (OverlapTest::Test(&planeA, &planeB) ? "true" : "false") << endl;
	}

}

int main()
{
	test_inside();
	test_collision();

    std::cout << "Hello World!\n"; 
	int a = 0;
	cin >> a;

}