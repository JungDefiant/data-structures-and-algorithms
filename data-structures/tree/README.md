# Tree
This program creates a binary tree and binary search tree

## Challenge
This challenge is to binary tree and binary search tree that successfully traverse the tree. For the binary search tree, it should be able to properly add new nodes to the tree or check if a node of a specific value is inside the tree.

## Approach & Efficiency
Unit tests for each functionality for the trees were created. After 'mapping out' the desired outcomes through unit tests, each function was made. Time complexities for methods are as follows.

* TraversePreOrder() -> O(n) since the method looks through the entire tree to accumulate all nodes
* TraverseInOrder() -> O(n) since the method looks through the entire tree to accumulate all nodes
* TraversePostOrder() -> O(n) since the method looks through the entire tree to accumulate all nodes
* Add() -> O(log n) since the method only traverses down the path matching the new node's value
* Contains() -> O(log n) since the method only traverses down the path matching the new node's value
* FindMaximumValue() -> O(n) since the method looks through the entire tree to find the highest value

## API
Public methods include:

* Tree.TraversePreOrder() -> Performs preorder traversal of the tree then returns array of all node values as an array
* Tree.TraverseInOrder() -> Performs inorder traversal of the tree then returns array of all node values as an array
* Tree.TraversePostOrder() -> Performs postorder traversal of the tree then returns array of all node values as an array
* Tree.FindMaximumValue() -> Searches through the tree and returns the highest value
* BinarySearchTree.Add() -> Creates a new tree with the given value, then adds it to the tree in the proper place
* BinarySearchTree.Contains() -> Searches through the tree for the first node with the given value

## Link To Code
[Link to Code](./Trees/)
