#pragma once
#include "Unit.h"

class SpecialUnit : public Unit
{
public:
	SpecialUnit();
	~SpecialUnit();
	virtual void Attack(Unit* pUnitToAttack);
	virtual void TakeDamage(Unit* pUnitAttacking, int nHealth);

	Unit* Create();

private:
	Unit* mUnit;
};