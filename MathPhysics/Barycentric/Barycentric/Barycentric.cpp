// Barycentric.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include "Source.h"
#include <iostream>

using namespace std;

int main()
{
    std::cout << "Test Center\n"; 
	{
		Barycentric myInterp;
		myInterp.addPoint(vec2(1.f, 0.f), 1.f);
		myInterp.addPoint(vec2(-.707f, -.707f), 1.f);
		myInterp.addPoint(vec2(.707f, -.707f), 1.f);

		cout << (fabs(myInterp.interpolation(vec2(0.f, 0.f)) - 1.f) < SMALL_NUMBER ? "correct" : "wrong") << endl;
	}
	std::cout << "Test Corners\n";
	{
		Barycentric myInterp;
		myInterp.addPoint(vec2(1.f, 0.f), 4.f);
		myInterp.addPoint(vec2(0.f, 1.f), 2.f);
		myInterp.addPoint(vec2(-1.f, 0.f), 3.f);

		cout << (fabs(myInterp.interpolation(vec2(1.f, 0.f)) - 4.f) < SMALL_NUMBER ? "correct" : "wrong") << endl;
		cout << (fabs(myInterp.interpolation(vec2(0.f, 1.f)) - 2.f) < SMALL_NUMBER ? "correct" : "wrong") << endl;
		cout << (fabs(myInterp.interpolation(vec2(-1.f, 0.f)) - 3.f) < SMALL_NUMBER ? "correct" : "wrong") << endl;
	}
	std::cout << "Test Edges\n";
	{
		Barycentric myInterp;
		myInterp.addPoint(vec2(0.f, 1.f), 4.f);
		myInterp.addPoint(vec2(0.f, -1.f), 2.f);
		myInterp.addPoint(vec2(-1.f, -1.f), 3.f);

		cout << (fabs(myInterp.interpolation(vec2(0.f, 0.f)) - 3.f) < SMALL_NUMBER ? "correct" : "wrong") << endl;
		cout << (fabs(myInterp.interpolation(vec2(-0.5f, -1.f)) - 2.5f) < SMALL_NUMBER ? "correct" : "wrong") << endl;
		cout << (fabs(myInterp.interpolation(vec2(-0.5f, 0.f)) - 3.5f) < SMALL_NUMBER ? "correct" : "wrong") << endl;
	}
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
