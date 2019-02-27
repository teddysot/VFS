#include <iostream>

using namespace std;
// basics on creating the tree
// lots is missing, but here's some general structure to get going

template<typename T>
class Node
{
public:
	shared_ptr<Node<T>> mParent = nullptr;
	shared_ptr<Node<T>> mLeft = nullptr;
	shared_ptr<Node<T>> mRight = nullptr;

	T mData;
};

template<typename T>
class BinaryTree
{
public:

	void add(int data)
	{
		cout << "[ADD] " << data << endl;
		_add(mRoot, data);
	}

	void remove(int data)
	{
		_remove(mRoot, data);
	}

	T findMin(shared_ptr<Node<T>>& root)
	{
		while (root->mLeft)
		{
			root = root->mLeft;
		}

		return root->mData;
	}

	void printPreOrder()
	{
		_printPreOrder(mRoot);
	}

	void printInOrder()
	{
		_printInOrder(mRoot);
	}

	void printPostOrder()
	{
		_printPostOrder(mRoot);
	}

private:

	shared_ptr<Node<T>> mRoot = nullptr;

	void _printPreOrder(shared_ptr<Node<T>>& root)
	{
		if (root == nullptr)
		{
			return;
		}
		cout << root->mData << " ";
		_printPreOrder(root->mLeft);
		_printPreOrder(root->mRight);
	}

	void _printInOrder(shared_ptr<Node<T>>& root)
	{
		if (root == nullptr)
		{
			return;
		}
		_printInOrder(root->mLeft);
		cout << root->mData << " ";
		_printInOrder(root->mRight);
	}

	void _printPostOrder(shared_ptr<Node<T>>& root)
	{
		if (root == nullptr)
		{
			return;
		}
		_printPostOrder(root->mLeft);
		_printPostOrder(root->mRight);
		cout << root->mData << " ";
	}

	void _remove(shared_ptr<Node<T>>& root, T data)
	{
		if (root != nullptr)
		{
			// Remove root
			if (root->mData == data)
			{
				// 
			}
		}
		else
		{
			cout << "Tree is empty" << endl;
		}
	}

	void _add(shared_ptr<Node<T>>& root, T data)
	{
		if (root == nullptr)
		{
			root = make_shared<Node<T>>();
			root->mData = data;
			return;
		}

		// find position in tree where to add
		if (data < root->mData)
		{
			if (root->mLeft == nullptr)
			{
				createLeftChild(root, data);
			}
			else
			{
				_add(root->mLeft, data);
			}
		}
		else
		{
			if (root->mRight == nullptr)
			{
				createRightChild(root, data);
			}
			else
			{
				_add(root->mRight, data);
			}
		}
	}

	void createLeftChild(shared_ptr<Node<T>>& parent, T data)
	{
		shared_ptr<Node<T>> node = make_shared<Node<T>>();
		node->mData = data;

		parent->mLeft = node;
		node->mParent = parent;
	}

	void createRightChild(shared_ptr<Node<T>>& parent, T data)
	{
		shared_ptr<Node<T>> node = make_shared<Node<T>>();
		node->mData = data;

		parent->mRight = node;
		node->mParent = parent;
	}

};

int main()
{
	BinaryTree<int> tree;
	tree.add(6);
	tree.add(4);
	tree.add(8);
	tree.add(1);
	tree.add(5);

	cout << "Pre Order: ";
	tree.printPreOrder();
	cout << endl;

	cout << "In Order: ";
	tree.printInOrder();
	cout << endl;

	cout << "Post Order: ";
	tree.printPostOrder();
	cout << endl;

	tree.remove(6);

	return 0;
}