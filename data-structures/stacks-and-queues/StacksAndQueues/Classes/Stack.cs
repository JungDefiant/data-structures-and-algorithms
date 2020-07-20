using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Pushes a new node with the given value to the Top of the Stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node node = new Node(value, Top);
            Top = node;
        }

        /// <summary>
        /// Removes the Top node from the Stack and returns it
        /// </summary>
        /// <returns></returns>
        public Node Pop()
        {
            try
            {
                Node temp = Top;
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
        public int Peek()
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
