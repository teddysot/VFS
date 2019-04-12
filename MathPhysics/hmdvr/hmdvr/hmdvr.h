#pragma once

#include <math.h>
#define SMALL_NUMBER 0.000000001f

using namespace std;

class vec2
{

public:
	vec2(float x, float y) : mx(x), my(y) {}

	float X() const { return mx; }
	float Y() const { return my; }

	vec2 operator* (float multiplier) { return vec2(multiplier*mx, multiplier*my); }

	float magnitude() const { return sqrt((mx * mx) + (my * my)); }
	vec2 normalized() const { return ((magnitude() > SMALL_NUMBER) ? vec2(mx / magnitude(), my / magnitude()) : vec2(0.f, 0.f)); }

private:
	float mx;
	float my;
};

class vec3
{

public:

	vec3(float x, float y, float z) : mx(x), my(y), mz(z) {}

	float X() const { return mx; }
	float Y() const { return my; }
	float Z() const { return mz; }

	vec3 operator+ (vec3 b) { return vec3(mx + b.X(), my + b.Y(), mz + b.Z()); }
	vec3 operator- (vec3 b) { return vec3(mx - b.X(), my - b.Y(), mz - b.Z()); }

	float dot(vec3& b) { return mx * b.X() + my * b.Y() + mz * b.Z(); }
	vec3 cross(vec3& b);

	float magnitude() const { return sqrt(mx * mx + my * my + mz * mz); }
	vec3 normalized() const { return (magnitude() > SMALL_NUMBER) ? vec3(mx / magnitude(), my / magnitude(), mz / magnitude()) : vec3(0.f, 0.f, 0.f); }

private:

	float mx;
	float my;
	float mz;
};

class matrix
{
public:
	matrix(float a, float b, float c, float d) : m_row1(a, b), m_row2(c, d) {}
	float determinant();

private:
	vec2 m_row1;
	vec2 m_row2;
};