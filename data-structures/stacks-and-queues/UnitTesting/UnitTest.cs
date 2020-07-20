using System;
using Xunit;
using StacksAndQueues.Classes;

namespace UnitTesting
{
    public class UnitTest
    {
        /*
            Can successfully push onto a stack
            Can successfully push multiple values onto a stack
            Can successfully pop off the stack
            Can successfully empty a stack after multiple pops
            Can successfully peek the next item on the stack
            Can successfully instantiate an empty stack
            Calling pop or peek on empty stack raises exception
            Can successfully enqueue into a queue
            Can successfully enqueue multiple values into a queue
            Can successfully dequeue out of a queue the expected value
            Can successfully peek into a queue, seeing the expected value
            Can successfully empty a queue after multiple dequeues
            Can successfully instantiate an empty queue
            Calling dequeue or peek on empty queue raises exception
         */

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
        /// 
        /// </summary>
        [Fact]
        public void CheckPeekStack()
        {
            Stack stack = new Stack();

            stack.Push(1);

            Assert.Equal(1, stack.Peek());
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void CheckCreateEmptyStack()
        {
            Stack stack = new Stack();

            Assert.Null(stack.Top);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void CheckThrowNullExceptionOnPop()
        {
            Stack stack = new Stack();

            Assert.Throws<NullReferenceException>(() => stack.Pop());
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void CheckSuccessfulEnqueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(20);

            Assert.Equal(20, queue.Front.Value);
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        [Fact]
        public void CheckCreateEmptyQueue()
        {
            Queue queue = new Queue();

            Assert.Null(queue.Front);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void CheckThrowNullExceptionOnDequeue()
        {
            Queue queue = new Queue();

            Assert.Throws<NullReferenceException>(() => queue.Dequeue());
        }
    }
}
