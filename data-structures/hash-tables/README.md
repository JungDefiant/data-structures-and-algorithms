# Hash Tables
This program creates a hashtable.

## Challenge
This challenge is to create a C# class that forms a hashtable data structure and handles operations for a hashtable.

## Approach & Efficiency
Unit tests for the method were created. After 'mapping out' the desired outcomes through unit tests, each function was made.

- Hashtable.GetHash --> O(1). This operation is only operate once on a given string.
- Hashtable.Add --> O(n). At worst, this algorithm iterates through each node in a particular bucket.
- Hashtable.GetValue --> O(n). At worst, this algorithm iterates through each node in a particular bucket.
- Hashtable.Contains --> O(n). At worst, this algorithm iterates through each node in a particular bucket.

## API
- Hashtable.GetHash --> Returns an integer when given a key based on a hashing algorithm
- Hashtable.Add --> Adds a new node with the given key and value to hashtable
- Hashtable.GetValue --> Finds node with the given key and returns its value
- Hashtable.Contains --> Finds node with given key and returns whether it has a node with that key

## Link To Code
[Link to Code](./HashTable/)

