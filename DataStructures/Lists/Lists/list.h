//======================================================================
// VFS: Data Structures And Algorithms
// Lesson 2: ArrayList & LinkedList
//======================================================================

#ifndef _LESSON2_LIST_H_
#define _LESSON2_LIST_H_

//======================================================================

#include <stdint.h>

//======================================================================
// Abstract Data Type: List
//======================================================================
template <class T>
class List
{
public:

	// Virtual Destructor, always need this for base classes.
	virtual ~List() {}

	// Appends entry to end of list.
	virtual bool Append(const T& entry) = 0;

	// Insert entry at supplied index, return true on success, false on error.
	virtual bool Insert(const T& entry, uint32_t const index) = 0;

	// Remove entry at supplied index, return true on success, false on error.
	virtual bool Remove(uint32_t const index) = 0;

	// Set entry to list entry at supplied index, return true on success or false on error.
	virtual bool At(T& entry, uint32_t const index) const = 0;

	// Return index of first instance of supplied entry or -1 if not found.
	virtual int32_t Find(const T& entry) const = 0;

	// Return current size of list.
	virtual uint32_t Size() const = 0;
};

//======================================================================

#endif

//======================================================================
