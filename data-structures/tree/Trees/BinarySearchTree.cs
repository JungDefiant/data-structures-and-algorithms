using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree : Tree
    {
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
