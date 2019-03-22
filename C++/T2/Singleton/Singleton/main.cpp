#include <iostream>

#include "Singleton.h"

using namespace std;

class Animal : public Singleton<Animal>
{
public:

	virtual void Walk() = 0;

	Animal() {}
	~Animal() {}
};

class Dog : public Animal
{
	virtual void Walk()
	{
		cout << "Dog walk" << endl;
	}
	Dog() {}
	~Dog() {}
};

int main()
{
	Dog::getInstance();

	system("pause");
	return 0;
}