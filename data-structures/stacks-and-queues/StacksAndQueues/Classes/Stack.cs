using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    internal class Stack
    {
        public Node Top { get; set; }

        public void Push(int value)
        {
            Node node = new Node(value, Top);
            Top = node;
        }

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
                return null;
            }
        }

        public int Peek()
        {
            try
            {
                return Top.Value;
            }
            catch(NullReferenceException)
            {
                return 0;
            }
        }
    }
}
