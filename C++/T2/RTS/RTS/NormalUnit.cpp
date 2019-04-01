#include "NormalUnit.h"

NormalUnit::NormalUnit()
{
	health = 100;
	type = Unknown;
	mUnit = nullptr;
}

NormalUnit::~NormalUnit()
{
	delete mUnit;
}

void NormalUnit::Attack(Unit * pUnitToAttack)
{
	mUnit->TakeDamage(pUnitToAttack, 10);
}

void NormalUnit::TakeDamage(Unit * pUnitAttacking, int nHealth)
{
	pUnitAttacking->health -= nHealth;
}

Unit * NormalUnit::Create()
{
	mUnit = new NormalUnit();
	mUnit->health = 100;
	mUnit->type = Normal;

	return mUnit;
}
