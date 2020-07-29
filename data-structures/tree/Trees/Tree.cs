using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Tree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Performs preorder traversal of the tree
        /// </summary>
        /// <returns>Array with all values of nodes in the tree, in preorder</returns>
        public int[] TraversePreOrder()
        {
            List<int> values = new List<int>();

            TraversePreOrder(Root, values);

            return values.ToArray();
        }

        /// <summary>
        /// Performs preorder traversal of the tree
        /// </summary>
        /// <param name="root">Current node being traversed</param>
        /// <param name="list">List of nodes that have been traversed</param>
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

        /// <summary>
        /// Performs inorder traversal of the tree
        /// </summary>
        /// <returns>Array with all values of nodes in the tree, in inorder</returns>
        public int[] TraverseInOrder()
        {
            List<int> values = new List<int>();

            TraverseInOrder(Root, values);

            return values.ToArray();
        }

        /// <summary>
        /// Performs inorder traversal of the tree
        /// </summary>
        /// <param name="root">Current node being traversed</param>
        /// <param name="list">List of nodes that have been traversed</param>
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

        /// <summary>
        /// Performs postorder traversal of the tree
        /// </summary>
        /// <returns>Array with all values of nodes in the tree, in postorder</returns>
        public int[] TraversePostOrder()
        {
            List<int> values = new List<int>();

            TraversePostOrder(Root, values);

            return values.ToArray();
        }

        /// <summary>
        /// Performs postorder traversal of the tree
        /// </summary>
        /// <param name="root">Current node being traversed</param>
        /// <param name="list">List of nodes that have been traversed</param>
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

        /// <summary>
        /// Finds highest value in tree by traversing through the whole tree
        /// </summary>
        /// <returns>Highest value in tree</returns>
        public int FindMaximumValue()
        {
            if (Root == null) throw new NullReferenceException();

            Node currentNode = Root;
            int max = Root.Value;

            return FindMaximumValue(max, currentNode);
        }

        /// <summary>
        /// Finds highest value in tree by traversing through the whole tree
        /// </summary>
        /// <param name="max">Current maximum value found</param>
        /// <param name="currentNode">Current node being traversed</param>
        /// <returns>Highest value in tree</returns>
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
