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

        public int GetHash(string key)
        {
            int total = 0;

            for (int i = 0; i < key.Length; i++)
            {
                total += key[i];
            }

            int prime = total * 13;
            int index = prime % Map.Length;

            return index;
        }

        public void Add(string key, T value)
        {
            int index = GetHash(key);
            Node<T> node = new Node<T>(value, key);

            if(Map[index] is null)
            {
                Map[index] = new LinkedList<Node<T>>();
            }

            // If the key already exists, replace its value with the new value
            if (!Contains(key)) Map[index].AddLast(node);
            else
            {
                var current = Map[index].First;
                while (!(current is null))
                {
                    if (current.Value.Key == key)
                    {
                        current.Value.Value = value;
                        return;
                    }

                    current = current.Next;
                }
            }
        }

        public T GetValue(string key)
        {
            int index = GetHash(key);

            if(!(Map[index] is null)) {
                var current = Map[index].First;
                while(!(current is null))
                {
                    if (current.Value.Key == key) return current.Value.Value;

                    current = current.Next;
                }
            }

            return default;
        }

        public bool Contains(string key)
        {
            int index = GetHash(key);

            if(!(Map[index] is null))
            {
                var current = Map[index].First;
                while (!(current is null))
                {
                    if (current.Value.Key == key) return true;

                    current = current.Next;
                }
            }

            return false;
        }
    }
}
