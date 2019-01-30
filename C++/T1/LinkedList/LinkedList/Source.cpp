#include <iostream>

using namespace std;

/*
Create a linked list class called "LinkedList" that contains templated node instances
Add methods to insert nodes:
void AddAtHead(T* pData) // creates node with data at the start of the linked list
void AddAtTail(T* pData) // creates node with data at the end of the linked list
Add methods to access the nodes:
T* GetHead(); // return head data
T* GetTail(); // return tail data
int GetSize(); // return the number of nodes
T* GetAt(int nIndex); // return data at index
Add methods to remove nodes:
void RemoveAt(int nIndex); // remove node at index
bool Remove(T* pData); // find and remove node via comparing data (return value is if removed or not)
Add clone method to duplicate the list
LinkedList* Clone(); // clones the current linked list, creating a new independent one
*/

template<typename T>
class Node
{
public:
	Node() :nData(nullptr), mNext(nullptr)
	{}

	T* nData;
	Node<T>* mNext;
};

template<typename T>
class LinkedList
{
public:
	LinkedList() :mHead(nullptr), mTail(nullptr) 
	{}

	void AddAtHead(T* pData) 
	{
		Node<T>* newNode = new Node<T>();
		newNode->nData = pData;

		if (mHead == nullptr)
		{
			mHead = newNode;
			mTail = newNode;
		}
		else
		{
			newNode->mNext = mHead;
			mHead = newNode;
		}
	}

	void AddAtTail(T* pData) 
	{
		Node<T>* newNode = new Node<T>();
		newNode->nData = pData;
		newNode->mNext = nullptr;

		if (mHead == nullptr)
		{
			mHead = newNode;
			mTail = newNode;
		}
		else
		{
			mTail->mNext = newNode->mNext;
			mTail = newNode;
		}
	}

	T* GetHead() 
	{
		return &mHead;
	}

	T* GetTail() 
	{
		return &mTail;
	}

	int GetSize() {}

	T* GetAt(int nIndex) {}

	void RemoveAt(int nIndex) {}

	bool Remove(T* pData) {}

	LinkedList* Clone() {}

	bool find(T* nData)
	{
		if (mHead == nullptr)
		{
			return false;
		}

		Node<T>* pNode = mHead;

		while (pNode != nullptr)
		{
			if (pNode->nData == nData)
			{
				delete pNode;
				return true;
			}

			pNode = pNode->mNext;
		}
		delete pNode;
		return false;
	}

	void remove(T* nData)
	{
		if (mHead == nullptr)
		{
			return;
		}

		Node<T>* temp = mHead;
		while (mHead != nullptr)
		{
			if (mHead->nData == nData)
			{
				Node<T>* pNode = temp->mNext;
				temp->mNext = temp->mNext->mNext;
				mHead = temp;
				delete pNode;

				return;
			}
			mHead = mHead->mNext;
		}

		return;
	}

private:
	Node<T>* mHead;
	Node<T>* mTail;
};

void main()
{
	LinkedList<int> ll;

	int data1 = 4;
	int data2 = 2;
	int data3 = 3;

	ll.AddAtHead(&data1);
	ll.AddAtHead(&data2);
	ll.AddAtTail(&data3);

	ll.remove(&data1);
}