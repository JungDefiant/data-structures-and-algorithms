using System;
using Xunit;
using Trees;
using System.Runtime.InteropServices;

namespace TreesUnitTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Checks whether an empty tree can be instantiated
        /// </summary>
        [Fact]
        public void CheckEmptyTreeInstantiation()
        {
            Tree tree = new Tree();

            Assert.Null(tree.Root);
        }

        /// <summary>
        /// Checks whether a tree with a single node can be instantiated
        /// </summary>
        [Fact]
        public void CheckTreeWithSingleRootInstantiation()
        {
            Tree tree = new Tree();
            tree.Root = new Node(1, null, null);

            Assert.NotNull(tree.Root);
        }

        /// <summary>
        /// Checks whether a tree with a left and right node can be instantiated
        /// </summary>
        [Fact]
        public void CheckAddLeftAndRightChild()
        {
            Tree tree = new Tree();

            Node left = new Node(2, null, null);
            Node right = new Node(3, null, null);
            tree.Root = new Node(1, left, right);

            Assert.True(tree.Root.Left != null && tree.Root.Right != null);
        }

        /// <summary>
        /// Checks whether a preorder traversal returns the correct array
        /// </summary>
        [Fact]
        public void CheckPreorderTraversal()
        {
            Tree tree = new Tree();

            tree.Root = new Node(1, 
                new Node(2, 
                    new Node(4, 
                        new Node(8, null, null), null),
                    new Node(6,
                        new Node(10, null, null),
                        new Node(12, null, null))),
                new Node(3,
                    new Node(5,
                        new Node(9, null, null),
                        new Node(11, null, null)),
                    new Node(7,
                        new Node(13, null, null), null)));

            int[] expected = new int[] { 1, 2, 4, 8, 6, 10, 12, 3, 5, 9, 11, 7, 13 };

            Assert.Equal(expected, tree.TraversePreOrder());
        }

        /// <summary>
        /// Checks whether an inorder traversal returns the correct array
        /// </summary>
        [Fact]
        public void CheckInorderTraversal()
        {
            Tree tree = new Tree();

            tree.Root = new Node(1,
                new Node(2,
                    new Node(4,
                        new Node(8, null, null), null),
                    new Node(6,
                        new Node(10, null, null),
                        new Node(12, null, null))),
                new Node(3,
                    new Node(5,
                        new Node(9, null, null),
                        new Node(11, null, null)),
                    new Node(7,
                        new Node(13, null, null), null)));

            int[] expected = new int[] { 8, 4, 2, 10, 6, 12, 1, 9, 5, 11, 3, 13, 7 };

            Assert.Equal(expected, tree.TraverseInOrder());
        }

        /// <summary>
        /// Checks whether a postorder traversal returns the correct array
        /// </summary>
        [Fact]
        public void CheckPostorderTraversal()
        {
            Tree tree = new Tree();

            tree.Root = new Node(1,
                new Node(2,
                    new Node(4,
                        new Node(8, null, null), null),
                    new Node(6,
                        new Node(10, null, null),
                        new Node(12, null, null))),
                new Node(3,
                    new Node(5,
                        new Node(9, null, null),
                        new Node(11, null, null)),
                    new Node(7,
                        new Node(13, null, null), null)));

            int[] expected = new int[] { 8, 4, 10, 12, 6, 2, 9, 11, 5, 13, 7, 3, 1 };

            Assert.Equal(expected, tree.TraversePostOrder());
        }

        /// <summary>
        /// Checks whether a binary search tree can add a root node
        /// </summary>
        [Fact]
        public void CheckBinarySearchTreeAddRoot()
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(1);

            Assert.NotNull(tree.Root);
        }

        /// <summary>
        /// Checks whether a binary search tree can add several nodes in the correct order
        /// </summary>
        [Fact]
        public void CheckBinarySearchTreeAddSeveral()
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(10);
            tree.Add(8);
            tree.Add(11);
            tree.Add(6);
            tree.Add(13);

            int[] expected = new int[] { 6, 8, 10, 11, 13 };

            Assert.Equal(expected, tree.TraverseInOrder());
        }

        /// <summary>
        /// Checks whether a binary search tree can see if tree contains a node
        /// </summary>
        /// <param name="test">Value of node to be checked</param>
        [Theory]
        [InlineData(11)]
        [InlineData(8)]
        [InlineData(13)]
        [InlineData(6)]
        [InlineData(10)]
        public void CheckBinarySearchTreeContains(int test)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(10);
            tree.Add(8);
            tree.Add(11);
            tree.Add(6);
            tree.Add(13);

            Assert.True(tree.Contains(test));
        }

        /// <summary>
        /// Checks whether tree can find highest value
        /// </summary>
        [Fact]
        public void CheckFindMaximumValue()
        {
            Tree tree = new Tree();

            tree.Root = new Node(1,
                new Node(2,
                    new Node(4,
                        new Node(8, null, null), null),
                    new Node(6,
                        new Node(10, null, null),
                        new Node(12, null, null))),
                new Node(3,
                    new Node(5,
                        new Node(9, null, null),
                        new Node(11, null, null)),
                    new Node(7,
                        new Node(13, null, null), null)));

            Assert.Equal(13, tree.FindMaximumValue());
        }
    }
}
