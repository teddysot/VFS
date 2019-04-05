#include <vector>
#pragma once

using namespace std;
//----------------------- Other Useful Code -----------------------------
class entity
{
public:

	entity(float cx, float cy, float rad) : mx(cx), my(cy), radius(rad) {}

	bool isOverlapping(entity& other)
	{
		float dx = mx - other.x();
		float dy = my - other.y();
		float totalRadius = radius + other.getRadius();

		return dx * dx + dy * dy <= totalRadius * totalRadius;
	}

	//accessors
	float x() const { return mx; }
	float y() const { return my; }
	float getRadius() const { return radius; }

protected:
	float mx;
	float my;

	float radius;
};

class box
{

public:
	box(float cx, float cy, float hw, float hh)
		: mx(cx), my(cy), mHalfWidth(hw), mHalfHeight(hh) {}

	float x() const { return mx; }
	float y()const { return my; }
	void getExtents(float& halfWidth, float& halfHeight) const
	{
		halfWidth = mHalfWidth;
		halfHeight = mHalfHeight;
	}

	bool isEntityOverlapping(entity& other)
	{
		//compare against each side of the box
		float dlp = PointToPlane(other.x(), other.y(), mx - mHalfWidth, my, -1.f, 0.f);		//leftplane
		float dtp = PointToPlane(other.x(), other.y(), mx, my + mHalfHeight, 0.f, 1.f);		//topplane
		float drp = PointToPlane(other.x(), other.y(), mx + mHalfWidth, my, 1.f, 0.f);		//rightplane
		float dbp = PointToPlane(other.x(), other.y(), mx, my - mHalfHeight, 0.f, -1.f); 	//bottomplane

		float cacheRadius = other.getRadius();
		if ((dlp < cacheRadius) && (dtp < cacheRadius) && (drp < cacheRadius) && (dbp < cacheRadius))
		{
			return true;
		}

		return false;
	}

protected:
	float mx;
	float my;

	float mHalfWidth;
	float mHalfHeight;

private:
	// not safe implementation
	float PointToPlane(float x, float y, float cx, float cy, float nx, float ny)
	{
		return (x - cx)*nx + (y - cy)*ny;
	}
};



void spawn(box&& spawnArea, int num, float radiusSize, vector<entity>& spawned);