using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HashTable
{
    public class Hashtable<T>
    {
        public LinkedList<Node<T>>[] Map { get; set; }

        public Hashtable(int size)
        {
            Map = new LinkedList<Node<T>>[size];
        }


    }
}
