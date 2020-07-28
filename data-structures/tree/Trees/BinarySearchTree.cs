using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree : Tree
    {
        public void Add(int value)
        {
            Node newNode = new Node(value, null, null);
            Node currentNode = Root;

            while(currentNode != null)
            {
                if(newNode.Value < currentNode.Value)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newNode;
                        currentNode = null;
                    }
                    else currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        currentNode = null;
                    }
                    else currentNode = currentNode.Right;
                }
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
