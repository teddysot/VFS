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
			mTail->mNext = newNode;
			mTail = newNode;
		}
	}

	T* GetHead()
	{
		return mHead->nData;
	}

	T* GetTail()
	{
		return mTail->nData;
	}

	int GetSize()
	{
		int count = 0;
		if (mHead == nullptr)
		{
			return count;
		}

		Node<T>* pNode = mHead;

		while (pNode != nullptr)
		{
			count++;
			pNode = pNode->mNext;
		}

		delete pNode;
		return count;
	}

	T* GetAt(int nIndex)
	{
		Node<T>* pNode = mHead;

		// if index = 0 return first index
		if (nIndex == 0)
		{
			return pNode->nData;
		}

		for (int i = 0; i < nIndex; i++)
		{
			pNode = mHead->mNext;
		}

		T* result = pNode->nData;

		delete pNode;
		return result;
	}

	void RemoveAt(int nIndex)
	{
		// If LinkedList is empty
		if (mHead == nullptr)
		{
			return;
		}

		// If index is 0
		if (nIndex == 0)
		{
			mHead = mHead->mNext;
			return;
		}

		Node<T>* temp = mHead;

		// Loop to the index node
		for (int i = 1; temp != nullptr && i < nIndex - 1; i++)
		{
			temp = temp->mNext;
		}

		// if it is the last node
		if (temp == nullptr || temp->mNext == nullptr)
		{
			mTail = temp;
			return;
		}

		Node<T>* next = temp->mNext->mNext;

		temp->mNext = next;

		mHead = temp;
	}

	bool Remove(T* pData)
	{
		// If LinkedList is empty
		if (mHead == nullptr)
		{
			return false;
		}

		Node<T>* temp = mHead;
		while (mHead != nullptr)
		{
			// Loop to the match nData
			if (mHead->nData == pData)
			{
				Node<T>* pNode = temp->mNext;
				temp->mNext = temp->mNext->mNext;
				mHead = temp;
				delete pNode;

				return true;
			}
			mHead = mHead->mNext;
		}

		// If there is no match nData
		return false;
	}

	LinkedList<T>* Clone()
	{
		LinkedList<T>* temp = new LinkedList<T>();
		Node<T>* cur = mHead;

		while (cur != nullptr)
		{
			temp->AddAtTail(cur->nData);
			cur = cur->mNext;
		}

		return temp;
	}

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
	// Test code
	LinkedList<int> ll;
	LinkedList<int>* ll2;

	int data1 = 4;
	int data2 = 2;
	int data3 = 3;
	int data4 = 1;
	int data5 = 6;
	int data6 = 5;

	ll.AddAtHead(&data1);
	ll.AddAtHead(&data2);
	ll.AddAtTail(&data3);
	ll.AddAtTail(&data4);
	ll.AddAtTail(&data5);
	ll.AddAtTail(&data6);

	ll.remove(&data1);

	ll.RemoveAt(0);

	ll2 = ll.Clone();

	cout << "Size: " << ll.GetSize() << endl;
	cout << "Head: " << *ll.GetHead() << endl;
	cout << "Tail: " << *ll.GetTail() << endl;
	cout << "LinkedList at 1: " << *ll.GetAt(1) << endl;


	system("pause");
}