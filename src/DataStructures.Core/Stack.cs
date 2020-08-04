using DataStructures.Core.Nodes;
using System;

namespace DataStructures.Core
{
    public class Stack
    {
        private Node Top;

        public Stack()
        {
            Top = null;
        }

        public bool IsEmpty
        {
            get
            {
                return Top == null;
            }
        }

        public void Push(int value)
        {
            var node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("empty stack");
            }

            var node = Top;
            Top = node.Next;
            return node.Value;
        }
    }
}
