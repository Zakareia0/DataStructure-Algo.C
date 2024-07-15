using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Structures_Course_2024.LinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = First;
            First = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = First;
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating thru list...");
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }


        public void InsertLast(int data)
        {
            Node current = First;
            while (current != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}