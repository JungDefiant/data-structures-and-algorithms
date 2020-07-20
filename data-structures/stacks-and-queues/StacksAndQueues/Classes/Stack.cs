using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node node = new Node(value, Top);
            Top = node;
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
