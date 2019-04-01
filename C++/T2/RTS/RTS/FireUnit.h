#pragma once
#include "Unit.h"

class FireUnit : public Unit
{
public:
	FireUnit();
	~FireUnit();
	virtual void Attack(Unit* pUnitToAttack);
	virtual void TakeDamage(Unit* pUnitAttacking, int nHealth);

	Unit* Create();

private:
	Unit* mUnit;
};