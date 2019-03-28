
#include "pch.h"
#include "Source.h"


weights Barycentric::computeWeights(float px, float py)
{
	/* your code here */
	float w1 = ((((mPoints[1].y() - mPoints[2].y()) * (px - mPoints[2].x())) + ((mPoints[2].x() - mPoints[1].x()) * (py - mPoints[2].y()))) /
		(((mPoints[1].y() - mPoints[2].y()) * (mPoints[0].x() - mPoints[2].x())) + ((mPoints[2].x() - mPoints[1].x()) * (mPoints[0].y() - mPoints[2].y()))));

	float w2 = ((((mPoints[2].y() - mPoints[0].y()) * (px - mPoints[2].x())) + ((mPoints[0].x() - mPoints[2].x()) * (py - mPoints[2].y()))) /
		(((mPoints[1].y() - mPoints[2].y()) * (mPoints[0].x() - mPoints[2].x())) + ((mPoints[2].x() - mPoints[1].x()) * (mPoints[0].y() - mPoints[2].y()))));

	float w3 = 1 - w1 - w2;



	return{ w1, w2, w3 };

}

float Barycentric::interpolation(float px, float py)
{
	weights baryWeights = computeWeights(px, py);

	/* Your code here*/
	float result = (((baryWeights.w1 * mValues[0]) + (baryWeights.w2 * mValues[1]) + (baryWeights.w3 * mValues[2])) / (baryWeights.w1 + baryWeights.w2 + baryWeights.w3));

	return result;
}
