using System;
using System.Text;
using StacksAndQueues.Classes;

namespace QueuesWithStacks
{
    public class PseudoQueue<T>
    {
        public Stack<T> Stack { get; set; }
        public Stack<T> DequeueStack { get; set; }

        public PseudoQueue()
        {
            Stack = new Stack<T>();
            DequeueStack = new Stack<T>();
        }

        public void Enqueue(T value)
        {
            try
            {
                Stack.Push(value);
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException();
            }
        }

        public Node<T> Dequeue()
        {
            try
            {
                while (Stack.Top.Next != null)
                {
                    Node<T> node = Stack.Pop();
                    Node<T> oldTop = DequeueStack.Top;
                    DequeueStack.Top = node;
                    if(oldTop != null) node.Next = oldTop;
                }

                Node<T> dequeueNode = Stack.Top;
                Stack.Top = null;

                while (DequeueStack.Top != null)
                {
                    Node<T> node = DequeueStack.Pop();
                    Node<T> oldTop = Stack.Top;
                    Stack.Top = node;
                    if (oldTop != null) node.Next = oldTop;
                }

                return dequeueNode;
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException();
            }
        }
    }
}
