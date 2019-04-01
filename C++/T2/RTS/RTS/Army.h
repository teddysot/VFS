#pragma once

#include <vector>

#include "Unit.h"

#include "NormalUnit.h"
#include "FireUnit.h"
#include "WaterUnit.h"
#include "SpecialUnit.h"

class Army
{
public:
	Army();
	~Army();

	// create the armies
	void CreateUnit(UnitType unitType);
	
	std::vector<Unit*> mUnits;

private:
	NormalUnit normalUnit;
	FireUnit fireUnit;
	WaterUnit waterUnit;
	SpecialUnit specialUnit;
};