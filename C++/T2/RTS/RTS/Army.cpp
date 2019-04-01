#include "Army.h"

Army::Army()
{
}

Army::~Army()
{
}

void Army::CreateUnit(UnitType unitType)
{
	switch (unitType)
	{
	case Normal:
		mUnits.push_back(normalUnit.Create());
		break;
	case Fire:
		mUnits.push_back(fireUnit.Create());
		break;
	case Water:
		mUnits.push_back(waterUnit.Create());
		break;
	case Special:
		mUnits.push_back(specialUnit.Create());
		break;
	default:
		mUnits.push_back(normalUnit.Create());
		break;
	}
}
