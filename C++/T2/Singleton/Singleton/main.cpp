#include <iostream>

#include "Singleton.h"

using namespace std;

class Dog : public Singleton<Dog>
{
public:

	void Walk()
	{
		cout << "Dog walk" << endl;
	}

	Dog() {}
	~Dog() {}
};

Dog* Singleton<Dog>::mInstance = nullptr;

int main()
{
	Dog::getInstance();

	system("pause");
	return 0;
}