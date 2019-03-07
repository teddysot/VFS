//======================================================================
// VFS: Data Structures And Algorithms
// Lesson 2: ArrayList & LinkedList
//======================================================================

#ifndef _LESSON2_ARRAYLIST_H_
#define _LESSON2_ARRAYLIST_H_

//======================================================================

#include "list.h"
#include <assert.h>

//======================================================================
// Data Structure: ArrayList
//======================================================================
template <class T>
class ArrayList : public List<T>
{
public:

	//------------------------------------------------------------------
	// Constructor: allocate array.
	ArrayList(uint32_t const maxSize) :
		mArray(nullptr),
		mMaxSize(0),
		mSize(0)
	{
		// Make sure size is valid.
		if (maxSize == 0)
		{
			return;
		}
		// Allocate array.
		mArray = new T[maxSize];
		// Set max size.
		mMaxSize = maxSize;
	}

	//------------------------------------------------------------------
	// Destructor: delete array.
	virtual ~ArrayList()
	{
		// Delete array.
		delete[] mArray;
		delete mArray;
	}

	//------------------------------------------------------------------
	// Appends entry to end of list.
	// Errors: List is full
	virtual bool Append(const T& entry) override
	{
		// Return false if size >= maxSize.
		if (mSize >= mMaxSize)
		{
			return false;       
		}
		// Assign array at size to entry.
		mArray[mSize] = entry;

		// Increment size.
		mSize++;

		return true;
	}


	//------------------------------------------------------------------
	// Insert entry at supplied index, return true on success, false on error.
	// Errors: index is outside list size, list is full.
	virtual bool Insert(const T& entry, uint32_t const index) override
	{
		// If the list full or the index is > size return false.
		if (mSize == mMaxSize || index > mSize)
		{
			return false;
		}
		// Make room, start at bottom and move everybody down one until
		// we reach index.
		for (int i = mSize; i > index - 1; i--)
		{
			mArray[i + 1] = mArray[i];
		}

		// Insert new entry.
		mArray[index] = entry;

		// Increment size.
		mSize++;

		return true;
	}

	//------------------------------------------------------------------
	// Remove entry at supplied index, return true on success, false on error.
	// Errors: index outside list size.
	virtual bool Remove(uint32_t const index) override
	{
		// If the list is empty or the index is >= size return false.
		if (mSize == 0 || index >= mSize)
		{
			return false;
		}

		// Start at index and move everybody up one.
		for (uint32_t i = index; i < mSize; i++)
		{
			mArray[i] = mArray[i + 1];
		}
		mArray[mSize] = NULL;

		// Decrement size.
		mSize--;

		return true;
	}

	//------------------------------------------------------------------
	// Return current size of list.
	virtual uint32_t Size() const override
	{
		// Return size.
		return mSize;
	}

	//------------------------------------------------------------------
	// Set entry = array entry at supplied index, return true on success or false on error.
	// Errors: index outside list size.
	bool At(T& entry, uint32_t const index) const override
	{
		// Return false if index >= size.
		if (index >= mSize)
		{
			return false;
		}

		// Assign entry to array entry at index.
		entry = mArray[index];

		return true;
	}

	//------------------------------------------------------------------
	// Return index of first instance of supplied entry or -1 if not found.
	virtual int32_t Find(const T& entry) const override
	{
		// Search for first instance of entry.
		for (uint32_t i = 0; i < mSize; i++)
		{
			if (mArray[i] == entry)
			{
				return i;
			}
		}
		return -1;
	}

protected:

	T* mArray;
	uint32_t mMaxSize;
	uint32_t mSize;
};

//======================================================================

#endif

//======================================================================
