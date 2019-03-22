#pragma once

// https://stackoverflow.com/questions/1008019/c-singleton-design-pattern
	// Note: Scott Meyers mentions in his Effective Modern
	//       C++ book, that deleted functions should generally
	//       be public as it results in better error messages
	//       due to the compilers behavior to check accessibility
	//       before deleted status

template<class T>
class Singleton
{
public:

	static T& getInstance()
	{
		if (mInstance == nullptr)
		{
			mInstance = new T();
		}

		return *mInstance;
	}

	static void ResetInstance()
	{
		delete mInstance;
		mInstance = nullptr;
	}

	// Thread safety
	Singleton() { };
	Singleton(const Singleton &) = delete;
	Singleton& operator=(const Singleton &) = delete;
	virtual ~Singleton() { }
	
private:
	static T* mInstance;
};
