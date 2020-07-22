using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        /// <summary>
        /// Pushes a new node with the given value to the Top of the Stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value, Top);
            Top = node;
        }

        /// <summary>
        /// Removes the Top node from the Stack and returns it
        /// </summary>
        /// <returns></returns>
        public Node<T> Pop()
        {
            try
            {
                Node<T> temp = Top;
                Top = Top.Next;
                return temp;
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Peeks into and returns the Top of the Stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            try
            {
                return Top.Value;
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Checks if Stack is Empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
