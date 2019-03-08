// PG15 - Math and Physics
// Teddy_Nasahachart

#include <cmath>
#include "vecMath.h"

using namespace std;

extern const float SMALL_FLOAT_TOLERANCE;

float vec3::X() const
{
	/** Your Code Here **/

	return mx;
}

float vec3::Y() const
{
	/** Your Code Here **/

	return my;
}

float vec3::Z() const
{
	/** Your Code Here **/

	return mz;
}

vec3 vec3::operator+ (vec3 b)
{
	/** Your Code Here **/

	return vec3(this->mx + b.mx, this->my + b.my, this->mz + b.mz);
}

vec3 vec3::operator- (vec3 b)
{
	/** Your Code Here **/

	return vec3(this->mx - b.mx, this->my - b.my, this->mz - b.mz);
}

float vec3::dot(vec3 b)
{
	/** Your Code Here **/

	return (mx * b.mx) + (my * b.my) + (mz * b.mz);;
}

// Determine if posB is visible from posA,
// if it is facing direction dirA with a tolerance of coneHalfAngle
// Expecation : return true if at or within (inclusive) the cone. return false otherwise
bool isWithinVisionCone(vec3 posA, vec3 dirA, vec3 posB, float coneHalfAngle)
{
	/** Your Code Here **/


	return false;
}
