#include <iostream>

using namespace std;

struct Vector2
{
	float x;
	float y;

	static float Magnitude(Vector2 v)
	{
		return sqrt((v.x * v.x) + (v.y * v.y));
	}

	static Vector2 Normalized(Vector2 v)
	{
		return { v.x / Magnitude(v), v.y / Magnitude(v) };
	}

	static float Dot(Vector2 v1, Vector2 v2)
	{
		return (v1.x * v2.x) + (v1.y * v2.y);
	}

	static Vector2 Cross(Vector2 v1, Vector2 v2)
	{
		Vector2 result =
		{ (v1.x * v2.y)
		, (-v1.y * v2.x) };

		return result;
	}
};

struct Vector3
{
	float x;
	float y;
	float z;

	static float Magnitude(Vector3 v)
	{
		return sqrt((v.x * v.x) + (v.y * v.y) + (v.z * v.z));
	}

	static Vector3 Normalized(Vector3 v)
	{
		return { v.x / Magnitude(v), v.y / Magnitude(v), v.z / Magnitude(v) };
	}

	static float Dot(Vector3 v1, Vector3 v2)
	{
		return (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
	}

	static Vector3 Cross(Vector3 v1, Vector3 v2)
	{
		Vector3 result =
		{ (v1.y * v2.z - v1.z * v2.y)
	   , -(v1.x * v2.z - v1.z * v2.x)
	   , (v1.x * v2.y - v1.y * v2.x) };

		return result;
	}
};

struct Matrix2
{
	float _11, _12;
	float _21, _22;

	static float Determinant(Matrix2 m)
	{
		return m._11 * m._22
			- (m._12 * m._21);
	}
};

struct Matrix3
{
	float _11, _12, _13;
	float _21, _22, _23;
	float _31, _32, _33;

	static float Determinant(Matrix3 m)
	{
		return m._11 * ((m._21 * m._33) - (m._23 * m._32))
			- (m._12 * ((m._21 * m._33) - (m._23 * m._31)))
			+ (m._13 * ((m._21 * m._32) - (m._22 * m._31)));
	}
};

int main()
{
	Matrix2 m2 =
	{
		6.7, 8.9,
		8.4, 8.1
	};

	printf("Matrix2 Determinant: %.1f\n", Matrix2::Determinant(m2));
	
	Matrix3 m3 =
	{
		6.7, 8.9, 1.1,
		8.4, 8.1, 5.5
	};

	printf("Matrix2 Determinant: %.1f\n", Matrix3::Determinant(m3));

	Vector2 v1 = { 1, 3 };
	Vector2 v2 = { -9, 0 };

	Vector2 crossResult = Vector2::Cross(v1, v2);
	printf("Vector3 Cross Product: ( %.1f, %.1f )\n", crossResult.x, crossResult.y);

	Vector3 v1 = { 1, 3, -4 };
	Vector3 v2 = { -9, 0, -4 };

	Vector3 crossResult = Vector3::Cross(v1, v2);
	printf("Vector3 Cross Product: ( %.1f, %.1f, %.1f )\n", crossResult.x, crossResult.y, crossResult.z);

	return 0;
}