#include <cmath>

// Base Class
class Shape
{
public:

	Shape(float x, float y) : mx(x), my(y) {}
	virtual ~Shape(){};

	virtual bool isInside(float x, float y) = 0;

	float getX() {return mx;};
	float getY() {return my;};

protected:

	float mx;
	float my;
	
};

//Axis-Aligned Bounding AABB : A box which does not rotate, always aligned with the x-y axis
class AABB : public Shape
{
public:

	AABB(float x, float y, float hw, float hh) : Shape(x,y), halfWidth(hw), halfHeight(hh){}
	virtual ~AABB() override {}

	virtual bool isInside(float x, float y) override;

	float getHalfWidth(){return halfWidth;}
	float getHalfHeight(){return halfHeight;}

private:

	float halfWidth;
	float halfHeight;

};


class Sphere : public Shape
{
public:

	Sphere(float x, float y, float r) : Shape(x,y),  radius(r){}
	virtual ~Sphere() override {}

	virtual bool isInside(float x, float y) override;

	float getRadius() {return radius;}
private:

	float radius;	
};

// Plane defined by any point on the surface + normal vector
class Plane : public Shape
{
public:

	Plane(float x, float y, float j, float k) : Shape(x,y), nx(j), ny(k){}
	virtual ~Plane() override {}
	
	virtual bool isInside(float x, float y) override;

	void getNormal(float& x, float& y)
	{
		x = nx;
		y = ny;
	}
private:

	float nx;
	float ny;
};


// Bunch of functions
// C++ does not have double dispatch, so you will not be able to treat
// both parameters polymorphically. 
// Sphere* sphereShape = new Sphere(1.f,2.f,3.f);
// NOT
// Shape* sphereShape = new Sphere(1.f,2.f,3.f);
// Some kind of visitor implementation will be needed alongside the
// Shape heirarchy which might be able to use these functions.
// Vistor pattern not required for this assignment. 
class OverlapTest
{

public:
	static bool Test(AABB* obja, AABB* objb);

	static bool Test(AABB* obja, Sphere* objb);
	static bool Test(Sphere* obja, AABB* boxb){ return Test(boxb, obja);}

	static bool Test(AABB* obja, Plane* objb);
	static bool Test(Plane* obja, AABB* boxb){ return Test(boxb, obja);}

	static bool Test(Sphere* obja, Sphere* objb);

	static bool Test(Sphere* obja, Plane* objb);
	static bool Test(Plane* obja, Sphere* objb){ return Test(objb, obja);}

	static bool Test(Plane* obja, Plane* objb);

	//Some helpful functions

	float dot(float x1, float y1, float x2, float y2){return x1*x2 + y1*y2;}

	float magnitude(float x, float y){return sqrt(x*x+y*y);}

	// Distance of a point to a plane
	// Positive value is in front of plane
	// Negative value is behind the plane
	// Will return a very large (ideally MAX_INT) if the plane is invalid
	float PointToPlane(float x, float y, Plane* inPlane)
	{
		float nx, ny;
		inPlane->getNormal(nx,ny);
		float normalMag = magnitude(nx,ny);

		if(normalMag <= 0.001) return 999999999.f; //good enough for test
		return dot(x - inPlane->getX(), y - inPlane->getY(),nx,ny) / magnitude(nx,ny);
	};

};


