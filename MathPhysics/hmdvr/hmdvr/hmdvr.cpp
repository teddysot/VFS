// hmdvr.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <vector>
#include "hmdvr.h"


/*
1. Implement a function which computes the determinant of a 2x2 matrix

2. Implement a function which computes the cross product of 2 vectors

3. VR Controllers and Head Mounted Displays (HMD), work best when within a defined playspace (Same is true for motion capture setups). A set of 4 points will define this playspace. We will assume that they form a convex shape on the floor. You will be given the (x,y,z) position of the HMD, and must determine if the user is within the acceptable playspace/quadrilateral.
Implement a function which accepts the position of the HMD, and the 4 points defining the playspace, return True or False if the HMD is inside the quadrilateral.
Using the cross-product method described in class
*/


float matrix::determinant()
{
	/* Your Code Here */
	return (m_row1.X() * m_row2.Y()) - (m_row1.Y() * m_row2.X());
}

vec3 vec3::cross(vec3& other)
{
	/* Your Code Here */
	vec3 result = { (my * other.mz - mz * other.my)
				 , -(mx * other.mz - mz * other.mx)
				 ,  (mx * other.my - my * other.mx) };

	return result;
}

bool isInsidePlayspace(vector<vec3> sensors, vec3 hmd)
{
	/* Your Code Here */
	vec3 a = hmd - sensors[0];
	vec3 b = hmd - sensors[1];
	vec3 c = hmd - sensors[2];
	vec3 d = hmd - sensors[3];

	vec3 result1 = a.cross(b);
	vec3 result2 = b.cross(c);
	vec3 result3 = c.cross(d);

	if (result1.Z() > 0.0f
		&& result2.Z() > 0.0f
		&& result3.Z() > 0.0f)
	{
		return true;
	}

	return false;
}

int main()
{

	{
		matrix mat(1.f, 0.f, 0.f, 1.f);
		cout << ((fabs(mat.determinant() - 1.f) < SMALL_NUMBER) ? "correct" : "wrong") << endl;
	}
	{
		matrix mat(2.f, 0.f, 0.f, 1.f);
		cout << ((fabs(mat.determinant() - 2.f) < SMALL_NUMBER) ? "correct" : "wrong") << endl;
	}
	{
		matrix mat(1.f, 0.f, 0.f, -2.f);
		cout << ((fabs(mat.determinant() + 2.f) < SMALL_NUMBER) ? "correct" : "wrong") << endl;
	}
	{
		matrix mat(0.f, 2.f, -3.f, 0.f);
		cout << ((fabs(mat.determinant() - 6.f) < SMALL_NUMBER) ? "correct" : "wrong") << endl;
	}

	{
		vec3 xaxis(1.f, 0.f, 0.f);
		vec3 yaxis(0.f, 1.f, 0.f);

		vec3 result = xaxis.cross(yaxis);
		result = result - vec3(0.f, 0.f, 1.f);
		float weakdiff = result.magnitude();
		
		cout << ((weakdiff < SMALL_NUMBER) ? "correct" : "wrong") << endl;
	}

	{
		vec3 xaxis(2.f, 0.f, 0.f);
		vec3 yaxis(0.f, 3.f, 0.f);

		vec3 result = xaxis.cross(yaxis);
		result = result - vec3(0.f, 0.f, 6.f);
		float weakdiff = result.magnitude();

		cout << ((weakdiff < SMALL_NUMBER) ? "correct" : "wrong") << endl;
	}

	{
		vec3 xaxis(1.f, 0.f, 0.f);
		vec3 yaxis(0.f, 1.f, 0.f);

		vec3 result = yaxis.cross(xaxis);
		result = result - vec3(0.f, 0.f,-1.f);
		float weakdiff = result.magnitude();

		cout << ((weakdiff < SMALL_NUMBER) ? "correct" : "wrong") << endl;
	}

	{
		vector<vec3> sensors;
		sensors.push_back(vec3(5.0f, 3.4f, 12.0f));
		sensors.push_back(vec3(-2.1f, 5.1f, 11.9f));
		sensors.push_back(vec3(-6.3f, -4.7f, 12.2f));
		sensors.push_back(vec3(5.2f, -3.8f, 11.7f));

		vec3 hmd = vec3(1.4f, 2.1f, 2.0f);
		cout << (isInsidePlayspace(sensors, hmd) ? "correct" : "wrong") << endl;

	}

    std::cout << "Hello World!\n"; 
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
