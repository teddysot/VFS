#include <iostream>
#include "vecMath.h"

using namespace std;

int main()
{
	/** code to test all of your implementations **/
	vec2 a(0.1f, 0.99f);

	cout << "Vector: <" << a.X() << ", " << a.Y() << ">" << endl;

	cout << "Magnitude: " << a.magnitude() << endl;

	float x = a.normalized().X();
	float y = a.normalized().Y();
	cout << "Normalize: <" << x << ", " << y << ">" << endl;

	a = applyDeadZone(a, 0.1f, 0.9f, 1.0f);
	cout << "Applied DZ: <" << a.X() << ", " << a.Y() << ">" << endl;


	return 0;	
}