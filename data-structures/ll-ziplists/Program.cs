using System;
using LLLibrary;

namespace LLZip
{
    class Program
    {
        static void Main(string[] args)
        {
			LinkedList L1 = new LinkedList();
			L1.Insert(1);
			L1.Append(12);
			L1.Append(16);
			L1.Append(20);
			DisplayLinkedList(L1.Head);

			LinkedList L2 = new LinkedList();
			L2.Insert(25);
			L2.Append(36);
			L2.Append(55);
			L2.Append(420);
			DisplayLinkedList(L2.Head);

			Node ZLHead = ZipList(L1, L2);
			DisplayLinkedList(ZLHead);

		}

		static void DisplayLinkedList(Node head)
        {
			Console.WriteLine("\nLinked List!");
			Console.WriteLine($"Value: {head.Value}");
			Node Current = head.Next;

			while(Current != null)
            {
				Console.WriteLine($"Value: {Current.Value}");
				Current = Current.Next;
			}

			Console.WriteLine("------------------");
		}

		static Node ZipList(LinkedList l1, LinkedList l2)
		{
			LinkedList ZipList = new LinkedList();
			Node L1_Frontier = l1.Head.Next;
			Node L2_Frontier = l2.Head.Next;
			ZipList.Head = l1.Head;
			ZipList.Head.Next = l2.Head;
			Node Current = ZipList.Head.Next;

			while (L1_Frontier != null
				&& L2_Frontier != null)
			{
				if (L1_Frontier != null)
				{
					Current.Next = L1_Frontier;
					Current = Current.Next;
					L1_Frontier = L1_Frontier.Next;
				}

				if (L2_Frontier != null)
				{
					Current.Next = L2_Frontier;
					Current = Current.Next;
					L2_Frontier = L2_Frontier.Next;
				}
			}

			return ZipList.Head;
		}

	}
}
