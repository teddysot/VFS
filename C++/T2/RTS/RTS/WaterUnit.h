#pragma once
#include "Unit.h"

class WaterUnit : public Unit
{
public:
	WaterUnit();
	~WaterUnit();
	virtual void Attack(Unit* pUnitToAttack);
	virtual void TakeDamage(Unit* pUnitAttacking, int nHealth);

	Unit* Create();

private:
	Unit* mUnit;
};