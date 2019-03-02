/**
	VFS Object Oriented Programming C++
	Purpose: Exercises in type casting

	@version 1.3 27/06/18
*/
#include <iostream>

//
// example classes you can use in the exercises below:
//

class Animal
{
public:
	int a = 10;
	virtual ~Animal() {}
};

class Mammal : public Animal
{
public:
	virtual ~Mammal() {}
};

class Human : public Mammal
{
public:
	virtual ~Human() {}
};

class Food
{
};

class Savoury : public Food
{
};

class Dessert : public Food
{
};

class Cake : public Dessert
{
};

//
// EXECISE ONE
//

//
// show an example of an implicit type conversion with an integral type
// show an example of an implicit type conversion with a pointer to a class
//

void ImplicitTypeConversion()
{
	// solve here
	short a = 0;
	int b = a;

	Animal* c = new Animal();
	Animal* d = c;
}

//
// EXECISE TWO
//

//
// show an example of a C style cast with an integral type
// show an example of a C style cast with a pointer to a class
//

void CStyleCast()
{
	// solve here
	short a = 0;
	int b = (int)a;

	Animal* c = new Animal();
	Animal* d = (Animal*)c;
}

//
// EXECISE THREE
//

//
// show an example of a static_cast using a pointer to a class
//

void StaticCast()
{
	// solve here
	Mammal* m = new Mammal();
	Animal* a = static_cast<Animal*>(m);
}

//
// EXECISE FOUR
//

//
// show an example of when a dynamic_cast succeeds
// show an example of when a dynamic_cast fails
//

void DynamicCast()
{
	// solve here

	// succeeds
	Mammal* m = new Mammal();
	Animal* a = dynamic_cast<Animal*>(m);

	// fail
	Animal* b = new Animal();
	Mammal* n = dynamic_cast<Mammal*>(b);
}

//
// EXECISE FIVE
//

//
// show an example of a const_cast
//

void ConstCast()
{
	// solve here

	Animal* a = new Animal();
	const Animal* b = a;
	Animal*c = const_cast<Animal*>(b);

	c->a = 11;

	std::cout << b->a;
	std::cout << c->a;
}

int main()
{
	ImplicitTypeConversion();
	CStyleCast();
	StaticCast();
	DynamicCast();
	ConstCast();

	return 0;
}