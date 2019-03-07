//======================================================================
// VFS: Data Structures And Algorithms
// Lesson 2: ArrayList & LinkedList
//======================================================================

#ifndef _LESSON2_LINKEDLIST_H_
#define _LESSON2_LINKEDLIST_H_

//======================================================================

#include "list.h"
#include <assert.h>

//======================================================================
// Data Structure: LinkedList
//======================================================================
template <class T>
class LinkedList : public List<T>
{
public:

	//------------------------------------------------------------------
	// Constructor: set head & tail pointer to null.
	LinkedList() :
		mHead(nullptr),
		mTail(nullptr),
		mSize(0)
	{
	}

	//------------------------------------------------------------------
	// Destructor: delete list.
	virtual ~LinkedList()
	{
		// Delete remaining nodes.
		Node* node = mHead;
		while (node != nullptr)
		{
			Node* const nextNode = node->mNext;
			delete node;
			node = nextNode;
		}
	}

	//------------------------------------------------------------------
	// Appends entry to end of list.
	// Errors: None
	virtual bool Append(const T& entry)
	{
		// Allocate newNode, assign entry and set prev,next pointers to null.
		Node* const newNode = new Node(entry);

		// If list is empty:
		//    set the head.
		if (mSize == 0)
		{
			mHead = newNode;
		}

		// If list is not empty:
		//    set tail's next pointer to newNode
		//    set newNode's prev pointer to tail.
		else
		{
			mTail->mNext = newNode;
			newNode->mPrev = mTail;
		}

		// Set tail to newNode.
		mTail = newNode;

		// Increment size.
		mSize++;

		return true;
	}

	//------------------------------------------------------------------
	// Insert entry at supplied index, return true on success, false on error.
	// Errors: index outside list size.
	virtual bool Insert(const T& entry, uint32_t const index) override
	{
		// Return false if index is > size.
		assert(index <= mSize);
		if (index > mSize)
		{
			return false;
		}

		// Allocate newNode, assign entry and set prev,next pointers to null.
		Node* const newNode = new Node(entry);

		// If we are inserting at 0:
		//    set newNode's next pointer to head
		//    if the list isn't empty set head's prev pointer to newNode
		//    otherwise set tail to newNode
		//    set head to newNode
		if (index == 0)
		{
			newNode->mNext = mHead;
			if (mHead != nullptr)
			{
				mHead->mPrev = newNode;
			}
			else
			{
				mTail = newNode;
			}
			mHead = newNode;
		}

		// If we are inserting at the end:
		//    set tail's next pointer to the new node
		//    set newNode's prev pointer to tail
		//    set tail to newNode
		else if (index == mSize)
		{
			mTail->mNext = newNode;
			newNode->mPrev = mTail;
			mTail = newNode;
		}

		// If we are not inserting at the head or tail:
		//    advance to prevNode (the node before the index we want to insert at: index - 1)
		//    get nextNode from prevNode's next pointer
		//    set newNode's prev pointer to prevNode
		//    set newNode's next pointer to nextNode
		//    set prevNode's next pointer to newNode
		//    set nextNode's prev pointer to newNode
		else
		{
			Node* prevNode = mHead;
			for (uint32_t i = 0; i < (index - 1); i++)
			{
				prevNode = prevNode->mNext;
			}
			Node* const nextNode = prevNode->mNext;
			newNode->mPrev = prevNode;
			newNode->mNext = nextNode;
			prevNode->mNext = newNode;
			nextNode->mPrev = newNode;
		}

		// Increment size.
		mSize++;

		return true;
	}

	//------------------------------------------------------------------
	// Remove entry at supplied index, return true on success, false on error.
	// Errors: index outside list size.
	virtual bool Remove(uint32_t const index) override
	{
		// Return false if index >= size.
		assert(index < mSize);
		if (index >= mSize)
		{
			return false;
		}

		// Init deleteNode to null.
		Node* deleteNode = nullptr;

		// If we are deleting index 0:
		//    set deleteNode to head
		//    set head to deleteNode's next pointer
		//    If we are not deleting the last entry set head's prev pointer to null
		//    otherwise set tail to null
		if (index == 0)
		{
			deleteNode = mHead;
			mHead = deleteNode->mNext;
			if (mHead != nullptr)
			{
				mHead->mPrev = nullptr;
			}
			else
			{
				mTail = nullptr;
			}
		}

		// If we are removing the last node:
		//    set deleteNode to tail
		//    set tail to deleteNode's prev pointer
		//    set tail's next pointer to null.
		else if (index == (mSize - 1))
		{
			deleteNode = mTail;
			mTail = deleteNode->mPrev;
			mTail->mNext = nullptr;
		}

		// If we are not removing at the head or tail:
		//    advance to prevNode (the node before the index we want to remove at: index - 1)
		//    set deleteNode to prevNode's next pointer
		//    set nextNode to deleteNode's next pointer
		//    set prevNode's next pointer to nextNode
		//    set nextNode's prev pointer to prevNode
		else
		{
			// Advance to node infront of node we are going to remove.
			Node* prevNode = mHead;
			for (uint32_t i = 0; i < (index - 1); i++)
			{
				prevNode = prevNode->mNext;
			}
			deleteNode = prevNode->mNext;
			Node* const nextNode = deleteNode->mNext;
			prevNode->mNext = nextNode;
			nextNode->mPrev = prevNode;
		}

		// Delete deleteNode (don't leak memory!)
		delete deleteNode;

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
		// If index >= size return false.
		assert(index < mSize);
		if (index >= mSize)
		{
			return false;
		}

		// If index is 0 use head's entry.
		if (index == 0)
		{
			entry = mHead->mEntry;
		}

		// If index is the last entry (size - 1) use tail's entry.
		else if (index == (mSize - 1))
		{
			entry = mTail->mEntry;
		}

		// Advance to node at index and use it's entry.
		else
		{
			Node* node = mHead;
			for (uint32_t i = 0; i < index; i++)
			{
				node = node->mNext;
			}
			entry = node->mEntry;
		}

		return true;
	}

	//------------------------------------------------------------------
	// Return index of first instance of supplied entry or -1 if not found.
	virtual int32_t Find(const T& entry) const override
	{
		// Search for first instance of entry.
		Node* node = mHead;
		for (uint32_t i = 0; i < mSize; i++)
		{
			if (node->mEntry == entry)
			{
				return static_cast<int32_t>(i);
			}
			node = node->mNext;
		}
		return -1;
	}

protected:

	struct Node
	{
		Node(const T& entry) :
			mEntry(entry),
			mNext(nullptr),
			mPrev(nullptr)
		{
		}

		T mEntry;
		Node* mPrev;
		Node* mNext;
	};

	Node* mHead;
	Node* mTail;
	uint32_t mSize;
};

//======================================================================

#endif

//======================================================================
