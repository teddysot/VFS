#pragma once

// ConsoleApplication2.cpp : Defines the entry point for the console application.
//

#include <list>
#include <string>
#include <functional>

typedef unsigned int Hash;
std::hash<std::string> s_hash;

//
// a hash map
//
// 1. only stores pointers
// 2. can assume T *always* has the element "mHash" that contains the hash
//

template<class T, int SIZE>
class HashMap
{
public:

	HashMap()
	{
		// TODO: maybe assert if SIZE isn't actually a power of two?
		mMask = SIZE - 1;
	}

	// TODO: insert data, return if succeeded
	bool Insert(T& data)
	{
		int index = Translate(data->mHash);

		if (&mBuckets[index] != nullptr)
		{
			return false;
		}

		mBuckets[index].push_back(data);

		return true;
	}

	void InsertNoCheck(T& data)
	{
		int index = Translate(data->mHash);
		mBuckets[index].push_back(data);
	}

	// TODO: find the data from the hash
	T Find(Hash hash)
	{
		int index = Translate(hash); // translate from the hash to the bucket index
		std::list<T>& targetBucket = mBuckets[index]; // grab a reference to the bucket via the bucket index

		for (auto data : targetBucket)
		{
			if (data->mHash == hash)
			{
				return data;
			}
		}

		return nullptr;
	}

	// TODO: find the data from the hash (but as const)
	const T Find(Hash hash) const
	{
		int index = Translate(hash); // translate from the hash to the bucket index
		const std::list<T>& targetBucket = mBuckets[index]; // grab a reference to the bucket via the bucket index

		for (auto data : targetBucket)
		{
			if (data->mHash == hash)
			{
				return data;
			}
		}

		return nullptr;
	}

	// TODO: delete the data from the hash
	void Delete(T data)
	{
		T temp = Find(data->mHash);

		if (temp != nullptr)
		{
			int index = Translate(temp->mHash);
			std::list<T>& targetBucket = mBuckets[index]; // grab a reference to the bucket via the bucket index

			targetBucket.remove(temp);
		}
	}

private:

	// TODO: explain why this works
	int Translate(Hash hash) const
	{
		return (hash & mMask);
	}

private:

	Hash mMask;

	// TODO: for bonus points, you could use your own linked list class!
	std::list<T> mBuckets[SIZE];
};

class MyObject
{
public:
	Hash mHash;
};