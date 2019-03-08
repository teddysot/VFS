// PG15 - Math and Physics
// Teddy_Nasahachart

#include <cmath>
#include "vecMath.h"

using namespace std;

const float SMALL_FLOAT_TOLERANCE = 0.001;

float vec2::X() const
{
	/** Your Code Here **/
	
	return mx;
}

float vec2::Y() const
{
	/** Your Code Here **/

	return my;
}

vec2 vec2::operator* (float multiplier)
{
	/** Your Code Here **/
	
	return  vec2(this->mx * multiplier, this->my * multiplier);
}

float vec2::magnitude() const
{
	/** Your Code Here **/
	
	return sqrt((mx * mx) + (my * my));;
}

vec2 vec2::normalized() const
{
	/** Your Code Here **/

	return vec2(mx / magnitude(), my / magnitude());
}

// For Reference 
// https://www.gamasutra.com/blogs/JoshSutphin/20130416/190541/Doing_Thumbstick_Dead_Zones_Right.php
// "The Right Way" is not enough. Provide a inner dead zone (below some theshold should return 0.0f)
// Also provide an upper dead zone (above some threshold the value is fixed)
// Think about why we might want this.
// Typical lowerThreshold ~ 0.1f
// Typical upperThreshold ~0.9f
// Typical upperValue = 1.f
// Expectations : 
//			1. At and below lowerThreshold value should be 0.f;
//			2. At and Above upperThreshold value should be upperValue;
//			3. Anywhere between lowerThreshold and upperThreshold should 
//				smoothly transistion from 0.f to UpperValue (linear)
//				linear function mapping [lowerThreshold, upperTheshold] -> [0.f, upperValue]

vec2 applyDeadZone(vec2 input, float lowerThreshold, float upperThreshold, float upperValue)
{
	/** Your Code Here **/
	if (input.magnitude() < lowerThreshold)
	{
		if (input.X() < lowerThreshold)
		{
			return vec2(0.0f, input.Y());
		}

		if (input.Y() < lowerThreshold)
		{
			return vec2(input.X(), 0.0f);
		}
	}

	else if (input.magnitude() > upperThreshold)
	{
		if (input.X() > upperThreshold)
		{
			return vec2(upperValue, input.Y());
		}

		if (input.Y() > upperThreshold)
		{
			return vec2(input.X(), upperValue);
		}
	}

	input = input.normalized() * ((input.magnitude() - lowerThreshold) / (upperValue - lowerThreshold));

	return input;
}