/**
	Purpose: Constructor exercises
	@class VFS Intro to C++
*/
#include <Windows.h>
#include <iostream>

using namespace std;

class MyClass1
{
public:
	int x;
	int y;
	int z;
};

//
// IMPORTANT! please note that for this exercise any copy constructor or copy assignment operator you implement should assign all values from the other instance to itself
//

//
// EXECISE ONE
//

//
// duplicate "MyClass1" and call it "MyClass2" but give it a constructor, destructor, copy constructor and a copy assignment operator
//
// create a function called "MyClass2Usage" that does the following:
//
// 1. create a variable "myClassA" of type "MyClass2"
// 2. create a variable "myClassB" of type "MyClass2" but use the copy constructor (using "myClassA" as the object to copy)
// 3. assign "myClassA" to "myClassB"
//

class MyClass2
{
public:
	// Contructor
	MyClass2()
	{
		x = 0;
		y = 0;
		z = 0;
	}

	// Destructor
	~MyClass2()
	{}

	// Copy Contructor
	MyClass2(const MyClass2& other)
	{
		x = other.x;
		y = other.y;
		z = other.z;
	}

	// Copy Assignment Operator
	MyClass2& operator=(const MyClass2& other)
	{
		x = other.x;
		y = other.y;
		z = other.z;

		return *this;
	}

	// Test Function
	void MyClass2Usage()
	{
		// 1.Create a variable "myClassA" of type "MyClass2"
		MyClass2 myClassA;
		cout << myClassA.x << myClassA.y << myClassA.z << endl;

		// 2.Create a variable "myClassB" of type "MyClass2" but use the copy constructor (using "myClassA" as the object to copy)
		MyClass2 myClassB(myClassA);
		cout << myClassB.x << myClassB.y << myClassB.z << endl;

		// 3.Assign "myClassA" to "myClassB"
		myClassB = myClassA;
		cout << myClassB.x << myClassB.y << myClassB.z << endl;
	}
private:
	int x;
	int y;
	int z;
};

//
// EXECISE TWO
//

//
// 1. duplicate "MyClass1" and call it "MyClass3" and give it a destructor and a constructor that has an argument list that will initialize all of the members
// 2. add code to "MyClass3" that will disallow the default constructor and copy constructor
//

class MyClass3
{
public:
	// Contructor
	MyClass3()
	{
		x = 0;
		y = 0;
		z = 0;
	}

	// Constructor with arguments
	MyClass3(int a, int b, int c)
	{
		x = a;
		y = b;
		z = c;
	}

	// Destructor
	~MyClass3()
	{}

	// Test Function
	void MyClass3Usage()
	{
		// Initialize Constrcutor with arguments
		MyClass3 myClassA(1, 2, 3);
		cout << myClassA.x << myClassA.y << myClassA.z << endl;
	}

private:

	// Copy Contructor and Copy Assignment Operator are in private to prevent copying from outside class
	// https://jrdodds.blogs.com/blog/2004/04/disallowing_cop.html
	// No Implementation
	MyClass3(const MyClass2&);
	MyClass3& operator=(const MyClass2&);

	int x;
	int y;
	int z;
};

//
// EXECISE THREE
//

//
// 1. duplicate "MyClass1" and call it "MyClass4" and add a constructor and destructor
// 2. make another class called "MyClass5" that inherits from "MyClass4"
// 3. add a constructor and destructor to "MyClass5"
//

class MyClass4
{
public:
	// Contructor
	MyClass4()
	{
		x = 0;
		y = 0;
		z = 0;
	}

	// Destructor
	~MyClass4()
	{}

	// Test Function
	void MyClass4Usage()
	{
		// Initialize Constrcutor
		MyClass4 myClassA;
		cout << myClassA.x << myClassA.y << myClassA.z << endl;
	}

	// public so MyClass5 can access them
	int x;
	int y;
	int z;
};

class MyClass5 : MyClass4
{
public:
	// Contructor
	MyClass5()
	{
		// Using members from MyClass4 and contruct them as MyClass5
		x = 1;
		y = 2;
		z = 3;
	}

	// Destructor
	~MyClass5()
	{}

	// Test Function
	void MyClass5Usage()
	{
		// Initialize Constrcutor
		MyClass5 myClassA;
		cout << myClassA.x << myClassA.y << myClassA.z << endl;
	}
};


int main()
{
	// Exercise 1 Test
	cout << "Exercise 1" << endl;

	MyClass2 mc2;
	cout << "MyClass2 Test" << endl;
	mc2.MyClass2Usage();

	// Exercise 2 Test
	cout << "Exercise 2" << endl;

	MyClass3 mc3;
	cout << "MyClass3 Test" << endl;
	mc3.MyClass3Usage();

	// Exercise 3 Test
	cout << "Exercise 3" << endl;
	MyClass4 mc4;
	cout << "MyClass4 Test" << endl;
	mc4.MyClass4Usage();

	MyClass5 mc5;
	cout << "MyClass5 Test" << endl;
	mc5.MyClass5Usage();

	system("pause");
	return 0;
}