#include <stdio.h>
#include <iostream>
#include <cmath>

using namespace std;

extern const float SMALL_FLOAT_TOLERANCE;

class vec2
{

public:
	vec2(float x, float y) : mx(x), my(y){}

	float X() const;
	float Y() const;

	vec2 operator* (float multiplier);

	float magnitude() const;
	vec2 normalized() const;

	friend std::ostream& operator<< (std::ostream& stream, const vec2& vec)
	{
		stream << "("  << vec.X() << " , " << vec.Y() << ")";
		return stream;
	}

private:
	float mx;
	float my;
};

class vec3
{

public:

	vec3(float x, float y, float z) : mx(x), my(y), mz(z){}

	float X() const;
	float Y() const;
	float Z() const;

	vec3 operator+ (vec3 b);
	vec3 operator- (vec3 b);
	
	float dot(vec3 b);
	float magnitude() const;
	vec3 normalized() const;

	friend std::ostream& operator<< (std::ostream& stream, const vec3& vec)
	{
		stream << "("  << vec.X() << " , " << vec.Y() << " , " << vec.Z() << ")";
		return stream;
	}

private:

	float mx;
	float my;
	float mz;	
};


vec2 applyDeadZone(vec2 input, float lowerThreshold, float upperThreshold, float upperValue);

bool isWithinVisionCone(vec3 posA, vec3 dirA, vec3 posB, float coneHalfAngle);
