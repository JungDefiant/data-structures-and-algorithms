using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        private Node front = null;
        public Node Front { get => front; set => front = value; }

        private Node rear = null;
        public Node Rear { get => rear; set => rear = value; }

        /// <summary>
        /// Adds node with given value to the Rear of the Queue. If Queue is empty, both 
        /// the Front and Rear are assigned to the new node.
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            Node node = new Node(value, null);
            
            if (IsEmpty())
            {
                front = node;
                rear = node;
            }
            else
            {
                rear.Next = node;
                rear = rear.Next;
            }
        }

        /// <summary>
        /// Removes and returns node from the Front of the Queue
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {
            try
            {
                Node temp = front;
                front = front.Next;
                return temp;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Peeks into and returns the Front of the Queue
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            try
            {
                return front;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Checks if Queue is Empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return front == null;
        }

    }
}
