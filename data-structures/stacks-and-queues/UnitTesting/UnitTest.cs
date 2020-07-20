using System;
using Xunit;
using StacksAndQueues.Classes;

namespace UnitTesting
{
    public class UnitTest
    {
        /// <summary>
        /// Checks whether a Stack pushes a new node successfully
        /// </summary>
        [Fact]
        public void CheckSuccessfulPush()
        {
            Stack stack = new Stack();

            stack.Push(1);

            Assert.Equal(1, stack.Top.Value);
        }

        /// <summary>
        /// Checks whether a Stack pushes multiple nodes successfully
        /// </summary>
        [Fact]
        public void CheckMultipleSuccessfulPushes()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Assert.Equal(4, stack.Top.Value);
        }

        /// <summary>
        /// Checks whether a Stack successfully pops a node
        /// </summary>
        [Fact]
        public void CheckSuccessfulPop()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Node node = stack.Pop();

            Assert.Equal(4, node.Value);
        }

        /// <summary>
        /// Check whether a stack is empty
        /// </summary>
        [Fact]
        public void CheckEmptyStack()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Assert.True(stack.IsEmpty());
        }

        /// <summary>
        /// Checks whether Peek() successfully returns from Stack
        /// </summary>
        [Fact]
        public void CheckPeekStack()
        {
            Stack stack = new Stack();

            stack.Push(1);

            Assert.Equal(1, stack.Peek());
        }

        /// <summary>
        /// Checks whether an empty stack is successfully instantiated
        /// </summary>
        [Fact]
        public void CheckCreateEmptyStack()
        {
            Stack stack = new Stack();

            Assert.Null(stack.Top);
        }

        /// <summary>
        /// Checks whether a Null Exception is thrown on Pop of empty Stack
        /// </summary>
        [Fact]
        public void CheckThrowNullExceptionOnPop()
        {
            Stack stack = new Stack();

            Assert.Throws<NullReferenceException>(() => stack.Pop());
        }

        /// <summary>
        /// Check if Queue successfully calls Enqueue
        /// </summary>
        [Fact]
        public void CheckSuccessfulEnqueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(20);

            Assert.Equal(20, queue.Front.Value);
        }

        /// <summary>
        /// Checks if multiple Enqueues are successful on Queue
        /// </summary>
        [Fact]
        public void CheckMultipleSuccessfulEnqueues()
        {
            Queue queue = new Queue();

            queue.Enqueue(20);
            queue.Enqueue(25);
            queue.Enqueue(30);
            queue.Enqueue(35);

            Assert.True(queue.Rear.Value == 35
                && queue.Front.Value == 20);
        }

        /// <summary>
        /// Checks if Queue successfully Dequeues
        /// </summary>
        [Fact]
        public void CheckSuccessfulDequeue()
        {
            Queue queue = new Queue();

            queue.Enqueue(20);
            queue.Enqueue(25);
            queue.Enqueue(30);
            queue.Enqueue(35);

            Node node = queue.Dequeue();

            Assert.Equal(20, node.Value);
        }

        /// <summary>
        /// Checks if Peek successfully returns from Queue
        /// </summary>
        [Fact]
        public void CheckPeekIntoQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(20);
            queue.Enqueue(25);
            queue.Enqueue(30);
            queue.Enqueue(35);

            Assert.Equal(20, queue.Peek().Value);
        }

        /// <summary>
        /// Checks if Queue is empty after several Enqueue and Dequeue calls
        /// </summary>
        [Fact]
        public void CheckEmptyQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(20);
            queue.Enqueue(25);
            queue.Enqueue(30);
            queue.Enqueue(35);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.True(queue.IsEmpty());
        }

        /// <summary>
        /// Checks if empty Queue is created successfully
        /// </summary>
        [Fact]
        public void CheckCreateEmptyQueue()
        {
            Queue queue = new Queue();

            Assert.Null(queue.Front);
        }

        /// <summary>
        /// Checks if a Null Exception is thrown when Dequeue called on empty Queue
        /// </summary>
        [Fact]
        public void CheckThrowNullExceptionOnDequeue()
        {
            Queue queue = new Queue();

            Assert.Throws<NullReferenceException>(() => queue.Dequeue());
        }
    }
}
