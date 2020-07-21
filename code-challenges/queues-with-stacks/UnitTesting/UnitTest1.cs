using System;
using Xunit;
using QueuesWithStacks;
using StacksAndQueues.Classes;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void CheckSuccessfulEnqueue()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(1);

            Assert.True(pseudoQueue.Stack.Top.Value == 1);
        }

        [Fact]
        public void CheckMultipleSuccessfulEnqueues()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(1);
            pseudoQueue.Enqueue(2);
            pseudoQueue.Enqueue(3);
            pseudoQueue.Enqueue(4);

            Assert.True(pseudoQueue.Stack.Top.Value == 4);
        }

        [Fact]
        public void CheckSuccessfulDequeue()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(1);
            pseudoQueue.Enqueue(2);
            Node<int> node = pseudoQueue.Dequeue();

            Assert.True(node.Value == 1);
        }

        [Fact]
        public void CheckMultipleSuccessfulDequeues()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(1);
            pseudoQueue.Enqueue(2);
            pseudoQueue.Enqueue(3);
            pseudoQueue.Enqueue(4);
            pseudoQueue.Dequeue();
            pseudoQueue.Dequeue();
            Node<int> node = pseudoQueue.Dequeue();

            Assert.True(node.Value == 3);
        }

        [Fact]
        public void CheckEmptyAfterMultipleEnqueuesDequeues()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(1);
            pseudoQueue.Enqueue(2);
            pseudoQueue.Enqueue(3);
            pseudoQueue.Enqueue(4);
            pseudoQueue.Dequeue();
            pseudoQueue.Dequeue();
            pseudoQueue.Dequeue();
            pseudoQueue.Dequeue();

            Assert.True(pseudoQueue.Stack.IsEmpty());
        }

        [Fact]
        public void CheckNullDequeueException()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            Assert.Throws<NullReferenceException>(() => pseudoQueue.Dequeue());
        }
    }
}
