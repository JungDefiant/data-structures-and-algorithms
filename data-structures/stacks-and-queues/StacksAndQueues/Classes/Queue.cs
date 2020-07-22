using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue<T>
    {
        private Node<T> front = null;
        public Node<T> Front { get => front; set => front = value; }

        private Node<T> rear = null;
        public Node<T> Rear { get => rear; set => rear = value; }

        /// <summary>
        /// Adds node with given value to the Rear of the Queue. If Queue is empty, both 
        /// the Front and Rear are assigned to the new node.
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value, null);
            
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
        public Node<T> Dequeue()
        {
            try
            {
                Node<T> temp = front;
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
        public Node<T> Peek()
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
