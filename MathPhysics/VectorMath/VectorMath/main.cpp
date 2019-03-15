#include <iostream>
#include "vecMath.h"

using namespace std;

int main()
{
	/** code to test all of your implementations **/
	vec2 a(0.1f, 0.99f);

	cout << "Vector2: <" << a.X() << ", " << a.Y() << ">" << endl;

	cout << "Magnitude: " << a.magnitude() << endl;

	float x = a.normalized().X();
	float y = a.normalized().Y();
	cout << "Normalized: <" << x << ", " << y << ">" << endl;

	a = applyDeadZone(a, 0.1f, 0.9f, 1.0f);
	cout << "Applied DZ: <" << a.X() << ", " << a.Y() << ">" << endl;

	vec3 b(3.0f, 4.0f, 5.0f);

	cout << "Vector3: <" << b.X() << ", " << b.Y() << ", " << b.Z() << ">" << endl;

	cout << "Magnitude: " << b.magnitude() << endl;

	cout << "Normalized: <" << b.normalized().X() << ", " << b.normalized().Y() << ", " << b.normalized().Z() << ">" << endl;

	vec3 posA(1.0f, 1.0f, 0.0f);
	vec3 dirA(1.0f, 10.0f, 0.0f);
	vec3 posB(5.0f, 1.0f, 0.0f);

	cout << "Has vision: " << (isWithinVisionCone(posA, dirA, posB, 30.0f) ? "true": "false") << endl;


	return 0;	
}