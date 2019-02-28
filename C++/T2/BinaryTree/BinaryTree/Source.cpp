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

	shared_ptr<Node<T>>& findMin(shared_ptr<Node<T>>& root)
	{
		if (root->mLeft == nullptr && root->mRight == nullptr)
		{
			return root;
		}
		else if (root->mLeft != nullptr)
		{
			if (root->mLeft->mLeft != nullptr)
			{
				findMin(root->mLeft);
			}
			else
			{
				return root->mLeft;
			}
		}
		else if (root->mLeft == nullptr)
		{
			findMin(root->mRight);
		}
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
				if (root->mLeft == nullptr && root->mRight == nullptr)
				{
					root = nullptr;
				}
				else
				{
					// Find min right and left most
					shared_ptr<Node<T>> temp = findMin(root->mRight);
					root->mData = temp->mData;
					_remove(root->mRight, temp->mData);
				}
				cout << "[REMOVE] " << data << endl;
				return;
			}

			// Remove left node
			if (data < root->mData)
			{
				if (data == root->mLeft->mData)
				{
					if (root->mLeft->mLeft != nullptr && root->mLeft->mRight == nullptr)
					{
						root = root->mLeft;
					}
					else if (root->mLeft->mLeft == nullptr && root->mLeft->mRight != nullptr)
					{
						root = root->mRight;
					}
					else if (root->mLeft->mLeft == nullptr && root->mLeft->mRight == nullptr)
					{
						root->mLeft = nullptr;
					}
					else
					{
						shared_ptr<Node<T>> temp = findMin(root->mLeft->mRight);
						root->mLeft->mData = temp->mData;
						_remove(root->mLeft->mRight, temp->mData);
					}
					cout << "[REMOVE] " << data << endl;
				}
				else
				{
					_remove(root->mLeft, data);
				}
			}

			// Remove Right node
			else if (data > root->mData)
			{
				if (data == root->mRight->mData)
				{
					if (root->mRight->mLeft != nullptr && root->mRight->mRight == nullptr)
					{
						root = root->mLeft;
					}
					else if (root->mRight->mLeft == nullptr && root->mRight->mRight != nullptr)
					{
						root = root->mRight;
					}
					else if (root->mRight->mLeft == nullptr && root->mRight->mRight == nullptr)
					{
						root->mRight = nullptr;
					}
					else
					{
						shared_ptr<Node<T>> temp = findMin(root->mRight->mRight);
						root->mRight->mData = temp->mData;
						_remove(root->mRight->mRight, temp->mData);
					}
					cout << "[REMOVE] " << data << endl;
				}
				else
				{
					_remove(root->mLeft, data);
				}
			}
		}
		else
		{
			cout << "Tree is empty" << endl;
		}
	}

	void _add(shared_ptr<Node<T>>& root, T data)
	{
		// If root is empty
		if (root == nullptr)
		{
			root = make_shared<Node<T>>();
			root->mData = data;
			return;
		}

		// Find position in tree where to add
		// Create left node
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
		// Create right node
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
	tree.add(10);

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

	cout << "Pre Order: ";
	tree.printPreOrder();
	cout << endl;

	cout << "In Order: ";
	tree.printInOrder();
	cout << endl;

	cout << "Post Order: ";
	tree.printPostOrder();
	cout << endl;

	tree.remove(4);

	cout << "Pre Order: ";
	tree.printPreOrder();
	cout << endl;

	cout << "In Order: ";
	tree.printInOrder();
	cout << endl;

	cout << "Post Order: ";
	tree.printPostOrder();
	cout << endl;

	return 0;
}