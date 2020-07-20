using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Constructor for a new Node
        /// </summary>
        /// <param name="value"></param>
        /// <param name="next"></param>
        public Node (int value, Node next)
        {
            Value = value;
            Next = next;
        }
    }
}
