//======================================================================
// VFS: Data Structures And Algorithms
// Lesson 2: ArrayList & LinkedList
//======================================================================

#include "linkedlist.h"
#include "arraylist.h"
#include <iostream>
#include <sstream>

//======================================================================

//#define USE_LINKED_LIST

//======================================================================

template <class T>
void dumpList(const std::string& message, List<T>& list)
{
	std::cout << message.c_str() << std::endl;
	std::cout << "-----------------------------------------------" << std::endl;
	for (uint32_t i = 0; i < list.Size(); i++)
	{
		T t;
		list.At(t, i);
		std::cout << "[" << i << "] " << t << std::endl;
	}
	std::cout << "-----------------------------------------------" << std::endl;
}

//======================================================================

int main()
{
#ifdef USE_LINKED_LIST
	List<double>& list = LinkedList<double>();
#else
	ArrayList<double> list = ArrayList<double>(7);
#endif

	list.Append(0.0);
	dumpList("Append 0.0", list);

	list.Append(1.0);
	dumpList("Append 1.0", list);

	list.Append(2.0);
	dumpList("Append 2.0", list);

	list.Append(3.0);
	dumpList("Append 3.0", list);

	list.Insert(1.5, 2);
	dumpList("Insert 1.5 at 2", list);

	list.Insert(4.0, 5);
	dumpList("Insert 4.0 at 5", list);

	list.Append(4.5);
	dumpList("Append 4.5", list);

	list.Remove(3);
	dumpList("Remove index 3", list);

	list.Remove(0);
	dumpList("Remove index 0", list);

	int32_t i = list.Find(4.5);
	std::cout << "Found 4.5 at index: " << i << std::endl;

	std::ostringstream t;
	t << "Remove index " << i;
	list.Remove(i);
	dumpList(t.str(), list);

	while (list.Size() > 0)
	{
		list.Remove(0);
		dumpList("Clearing List", list);
	}
	system("pause");

	return 0;
}

//======================================================================
