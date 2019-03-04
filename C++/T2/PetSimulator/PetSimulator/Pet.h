#pragma once
#include <Windows.h>
#include <string>

class Pet
{
public:
	Pet();
	~Pet();

	void setName(std::string name);

	std::string getName();
	float getHunger();
	float getThirst();
	float getSleepiness();
	float getHappiness();

	void Eat(float amount);
	void Walk(float distance);
	void Sleep(float amount);
	void Playing(float amount);
	void WatchMovie(float amount);
	void Toilet();

	bool checkHealth();

	void Reset();

private:
	void checkStats();

	std::string petName;
	float hunger;
	float thirst;
	float sleepiness;
	float happiness;
};