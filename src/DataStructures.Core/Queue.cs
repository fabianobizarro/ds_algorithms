using DataStructures.Core.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Core
{
    public class Queue
    {
        private Node Head;

        private Node Tail;

        public Queue()
        {
            Head = null;
            Tail = null;
        }

        public bool IsEmpty() => Head == Tail;

        public int Peek()
        {
            return Head.Value;
        }

        public void Enqueue(int value)
        {
            var node = new Node(value);
            if (Head == null)
            {
                Head = node;
                Tail = Head;
                Tail.Next = null;
            }
            else
            {
                Tail.Next = new Node(value);
                Tail = Tail.Next;
                Tail.Next = null;
            }
        }

        public int Dequeue()
        {
            var value = Head.Value;
            Head = Head.Next;
            if (Head == null)
            {
                Tail = null;
            }
            return value;
        }
    }
}
