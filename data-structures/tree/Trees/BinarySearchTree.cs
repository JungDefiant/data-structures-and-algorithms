using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree : Tree
    {
        
        /// <summary>
        /// Creates a node with the given value then adds it to the tree according to its value
        /// </summary>
        /// <param name="value">Value of the new node</param>
        public void Add(int value)
        {
            Node currentNode = null;
            Node newNode = new Node(value, null, null);

            if (Root == null)
            {
                Root = newNode;
                return;
            }
            else currentNode = Root;

            if (newNode.Value < currentNode.Value)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    return;
                }
                else Add(newNode, currentNode.Left);
            }
            else
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                    return;
                }
                else Add(newNode, currentNode.Right);
            }
        }

        /// <summary>
        /// Adds node to tree based on its value
        /// </summary>
        /// <param name="newNode">Node to be added to the tree</param>
        /// <param name="currentNode">Current node being traversed</param>
        public void Add(Node newNode, Node currentNode)
        {
            if (newNode.Value < currentNode.Value)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    return;
                }
                else Add(newNode, currentNode.Left);
            }
            else
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                    return;
                }
                else Add(newNode, currentNode.Right);
            }
        }

        /// <summary>
        /// Checks if node of specific value is in tree
        /// </summary>
        /// <param name="value">Value to be checked</param>
        /// <returns>Returns true or false, depending on if node with given value is found</returns>
        public bool Contains(int value)
        {
            Node currentNode = Root;

            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else if (value > currentNode.Value)
                {
                    currentNode = currentNode.Right;
                }
                else return true;
            }

            return false;
        }
    }
}
