using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Tree
    {
        public Node Root { get; set; }

        public int[] TraversePreOrder()
        {
            List<int> values = new List<int>();

            TraversePreOrder(Root, values);

            return values.ToArray();
        }

        public void TraversePreOrder(Node root, List<int> list)
        {
            list.Add(root.Value);

            if (root.Left != null)
            {
                TraversePreOrder(root.Left, list);
            }

            if (root.Right != null)
            {
                TraversePreOrder(root.Right, list);
            }
        }

        public int[] TraverseInOrder()
        {
            List<int> values = new List<int>();

            TraverseInOrder(Root, values);

            return values.ToArray();
        }

        public void TraverseInOrder(Node root, List<int> list)
        {
            if (root.Left != null)
            {
                TraverseInOrder(root.Left, list);
            }

            list.Add(root.Value);

            if (root.Right != null)
            {
                TraverseInOrder(root.Right, list);
            }
        }

        public int[] TraversePostOrder()
        {
            List<int> values = new List<int>();

            TraversePostOrder(Root, values);

            return values.ToArray();
        }

        public void TraversePostOrder(Node root, List<int> list)
        {
            if (root.Left != null)
            {
                TraversePostOrder(root.Left, list);
            }

            if (root.Right != null)
            {
                TraversePostOrder(root.Right, list);
            }

            list.Add(root.Value);
        }

        public int FindMaximumValue()
        {
            if (Root == null) throw new NullReferenceException();

            Node currentNode = Root;
            int max = Root.Value;

            return FindMaximumValue(max, currentNode);
        }

        public int FindMaximumValue(int max, Node currentNode)
        {
            if (currentNode.Value > max) max = currentNode.Value;
            
            if(currentNode.Left != null)
            {
                max = FindMaximumValue(max, currentNode.Left);
            }

            if (currentNode.Right != null)
            {
                max = FindMaximumValue(max, currentNode.Right);
            }

            return max;
        }
    }
}
