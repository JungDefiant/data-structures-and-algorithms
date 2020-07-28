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

            while (root.Left != null)
            {
                TraversePreOrder(root.Left, list);
            }

            while (root.Right != null)
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
            while (root.Left != null)
            {
                list.Add(root.Left.Value);
                TraverseInOrder(root.Left, list);
            }

            list.Add(root.Value);

            while (root.Right != null)
            {
                list.Add(root.Right.Value);
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
            while (root.Left != null)
            {
                list.Add(root.Left.Value);
                TraversePostOrder(root.Left, list);
            }

            while (root.Right != null)
            {
                list.Add(root.Right.Value);
                TraversePostOrder(root.Right, list);
            }

            list.Add(root.Value);
        }
    }
}
