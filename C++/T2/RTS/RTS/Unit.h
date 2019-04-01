#pragma once
enum UnitType
{
	Unknown = 0,
	Normal,
	Fire,
	Water,
	Special
};

class Unit
{
public:
	virtual void Attack(Unit* pUnitToAttack) = 0;
	virtual void TakeDamage(Unit* pUnitAttacking, int nHealth) = 0;

	int health;
	UnitType type;
};