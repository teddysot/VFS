#pragma once
#include "Unit.h"

class NormalUnit : public Unit
{
public:
	NormalUnit();
	~NormalUnit();
	virtual void Attack(Unit* pUnitToAttack);
	virtual void TakeDamage(Unit* pUnitAttacking, int nHealth);

	Unit* Create();

private:
	Unit* mUnit;
};