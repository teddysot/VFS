#include "SpecialUnit.h"

SpecialUnit::SpecialUnit()
{
	health = 100;
	type = Unknown;
	mUnit = nullptr;
}

SpecialUnit::~SpecialUnit()
{
	delete mUnit;
}

void SpecialUnit::Attack(Unit * pUnitToAttack)
{
	mUnit->TakeDamage(pUnitToAttack, 10);
}

void SpecialUnit::TakeDamage(Unit * pUnitAttacking, int nHealth)
{
	pUnitAttacking->health -= nHealth;
}

Unit * SpecialUnit::Create()
{
	mUnit = new SpecialUnit();
	mUnit->health = 100;
	mUnit->type = Special;

	return mUnit;
}
