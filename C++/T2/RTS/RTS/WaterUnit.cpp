#include "WaterUnit.h"

WaterUnit::WaterUnit()
{
	health = 100;
	type = Unknown;
	mUnit = nullptr;
}

WaterUnit::~WaterUnit()
{
	delete mUnit;
}

void WaterUnit::Attack(Unit * pUnitToAttack)
{
	mUnit->TakeDamage(pUnitToAttack, 10);
}

void WaterUnit::TakeDamage(Unit * pUnitAttacking, int nHealth)
{
	pUnitAttacking->health -= nHealth;
}

Unit * WaterUnit::Create()
{
	mUnit = new WaterUnit();
	mUnit->health = 100;
	mUnit->type = Water;

	return mUnit;
}
