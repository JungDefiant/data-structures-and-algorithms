using System;
using Xunit;
using Trees;
using System.Runtime.InteropServices;

namespace TreesUnitTest
{
    public class UnitTest1
    {
        // Can successfully instantiate an empty tree
        // Can successfully instantiate a tree with a single root node
        // Can successfully add a left child and right child to a single root node
        // Can successfully return a collection from a preorder traversal
        // Can successfully return a collection from an inorder traversal
        // Can successfully return a collection from a postorder traversal

        [Fact]
        public void CheckEmptyTreeInstantiation()
        {
            Tree tree = new Tree();

            Assert.Null(tree.Root);
        }

        [Fact]
        public void CheckTreeWithSingleRootInstantiation()
        {
            Tree tree = new Tree();
            tree.Root = new Node(1, null, null);

            Assert.NotNull(tree.Root);
        }

        [Fact]
        public void CheckAddLeftAndRightChild()
        {
            Tree tree = new Tree();

            Node left = new Node(2, null, null);
            Node right = new Node(3, null, null);
            tree.Root = new Node(1, left, right);

            Assert.True(tree.Root.Left != null && tree.Root.Right != null);
        }

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

        [Fact]
        public void CheckBinarySearchTreeAddRoot()
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(1);

            Assert.NotNull(tree.Root);
        }

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
    }
}
