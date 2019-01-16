/**
    VFS Intro to C++
    Purpose: Pointer exercises using a class

    @class Intro to Programming in C++
    @version 1.1
*/

#include <iostream>

class Dog
{
public:

	Dog()
	{
		mNoises = 0;
	}
	
	void Woof()
	{
		std::cout << "WOOF!" << std::endl;
		++mNoises;
	}

private:

	int mNoises;

};

//
// EXECISE ONE
//

//
// create a function called "CreateDog" that returns an instance of "Dog" using dynamically allocated memory
//


Dog* CreateDog()
{
	Dog * d = new Dog();

	std::cout << "Create Dog" << std::endl;
	return d;
}


//
// EXECISE TWO
//

//
// create a function called "BarkThreeTimes" that uses an instance returned from "CreateDog" and then makes the dog bark three times
//


void BarkThreeTimes(Dog *d)
{
	if (d == nullptr)
	{
		return;
	}
	for (int i = 0; i < 3; i++)
	{
		d->Woof();
	}
}


//
// EXECISE THREE
//

//
// 1. create a function called "ThreeDogsBark2" that takes three "Dog" pointers as parameters and then makes each dog bark once
// 2. create a function called "ThreeDogsBark1" that creates three dogs using "CreateDog" and then passes them to "ThreeDogsBark2"


void ThreeDogsBark2(Dog *d1, Dog *d2, Dog *d3)
{
	if (d1 != nullptr)
	{
		d1->Woof();
	}

	if (d2 != nullptr)
	{
		d2->Woof();
	}

	if (d3 != nullptr)
	{
		d3->Woof();
	}
}

void ThreeDogsBark1()
{
	Dog *d1 = CreateDog();
	Dog	*d2 = CreateDog();
	Dog	*d3 = CreateDog();

	ThreeDogsBark2(d1, d2, d3);

	delete d1;
	delete d2;
	delete d3;
}


//
// EXECISE FOUR
//

// create a function called "ThreeDogsBarkStack" that creates three "Dog" instances on the stack and then passes them to "ThreeDogsBark2"
//


// Heap is static variable
void ThreeDogsBarkStack()
{
	Dog d1;
	Dog d2;
	Dog d3;

	ThreeDogsBark2(&d1, &d2, &d3);
}



int main()
{
	// Test

	// Exercise 1
	std::cout << "Exercise 1\n";
	Dog *d = CreateDog();

	// Exercise 2
	std::cout << "\n\nExercise 2\n";
	BarkThreeTimes(d);

	// Exercise 3
	std::cout << "\n\nExercise 3\n";
	ThreeDogsBark1();

	// Exercise 4
	std::cout << "\n\nExercise 4\n";
	ThreeDogsBarkStack();

	delete d;
	
	return 0;
}