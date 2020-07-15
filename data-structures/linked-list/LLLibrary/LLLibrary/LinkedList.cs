using System;
using System.Collections.Generic;
using System.Text;

namespace LLLibrary
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkedList()
        {
            Head = null;
            Current = Head;
        }

        /// <summary>
        /// Inserts a new node with an O(1) operation into linkedList
        /// </summary>
        /// <param name="value">value to be strored in the node</param>
        public void Insert(int value)
        {
            Current = Head;
            // create teh new node that needs to be added
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Finds a specific value in the linked list
        /// O(n) time efficiency
        /// </summary>
        /// <param name="value">searchable value</param>
        /// <returns>response if it exists</returns>
        public bool Includes(int value)
        {
            Current = Head;
            // While loop
            // traverse the linked list and do the comparison
            while (Current != null)
            {
                // check if it's equal to the given value
                if (Current.Value == value)
                {
                    return true;
                }

                // move to the next one
                Current = Current.Next;
            }

            return false;
        }

        /// <summary>
        /// Takes an integer, creates a new node with that value, then appends the node to the end of the linked list
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Node node = new Node(value);
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = node;
        }

        /// <summary>
        /// Returns the value of the node that is 'k' away from the end of the linked list
        /// </summary>
        /// <param name="k">number of steps from end of linked list to find node</param>
        /// <returns>value of node that is 'k' away from end of linked list</returns>
        public int KthFromTheEnd(int k)
        {
            List<int> values = new List<int>();
            values.Add(Head.Value);

            Current = Head;
            
            while(Current.Next != null)
            {
                Current = Current.Next;
                values.Add(Current.Value);
            }

            if (values.Count - (k + 1) < 0) throw new Exception();
            else return values[values.Count - (k + 1)];
        }

        /// <summary>
        /// Overriding current behavior of tostring method to output all values in the linked list as a string 
        /// </summary>
        /// <returns>a string containing all the values of the linked list</returns>
        public override string ToString()
        {
            Current = Head;
            // StringBuilder class. 
            // why would you use Stringbuilder over string concatination??

            StringBuilder sb = new StringBuilder();

            // start constructing sb
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            sb.Append("NULL");

            return sb.ToString();
        }
    }
}
