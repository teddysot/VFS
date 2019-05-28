#include "HashMap.h"

int main()
{
	Hash HELLO_hash = s_hash("HELLO");

	MyObject* myObject = new MyObject();
	myObject->mHash = HELLO_hash;

	HashMap<MyObject*, 256> myHashMap;
	myHashMap.InsertNoCheck(myObject);
	myHashMap.Insert(myObject);
	myHashMap.Find(HELLO_hash);
	myHashMap.Delete(myObject);

	delete myObject;

	return 0;
}