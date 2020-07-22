using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        /// <summary>
        /// Constructor for a new Node
        /// </summary>
        /// <param name="value"></param>
        /// <param name="next"></param>
        public Node (T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}
