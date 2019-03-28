#pragma once

#include <vector>
#include <math.h>

#define SMALL_NUMBER 0.0001f

class vec2
{
public:
	vec2() : mx(0.f), my(0.f) {}
	vec2(float x, float y) : mx(x), my(y) {};

	float x() { return mx; }
	float y() { return my; }
private:
	float mx;
	float my;
};

struct weights
{
	float w1;
	float w2;
	float w3;
};

class Barycentric
{
public:
	Barycentric() {};

	void addPoint(vec2 location, float value)
	{
		mPoints.push_back(location);
		mValues.push_back(value);
	}

	float interpolation(vec2 point) { return interpolation(point.x(), point.y()); }

private:

	float interpolation(float px, float py);

	weights computeWeights(float px, float py);

	weights computeWeights(vec2 point)
	{
		return computeWeights(point.x(), point.y());
	}

	std::vector<vec2> mPoints;
	std::vector<float> mValues;

};