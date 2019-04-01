#include "FireUnit.h"

FireUnit::FireUnit()
{
	health = 100;
	type = Unknown;
	mUnit = nullptr;
}

FireUnit::~FireUnit()
{
	delete mUnit;
}

void FireUnit::Attack(Unit * pUnitToAttack)
{
	mUnit->TakeDamage(pUnitToAttack, 10);
}

void FireUnit::TakeDamage(Unit * pUnitAttacking, int nHealth)
{
	pUnitAttacking->health -= nHealth;
}

Unit* FireUnit::Create()
{
	mUnit = new FireUnit();
	mUnit->health = 100;
	mUnit->type = Fire;

	return mUnit;
}
