namespace DataStructures.Core.Nodes
{
    public class Node
    {
        public readonly int Value;

        public Node Next = null;

        public Node(int value)
        {
            Value = value;
        }
    }

    public class DoubleNode
    {
        public readonly int Value;

        public DoubleNode Next = null;
        public DoubleNode Prev = null;

        public DoubleNode(int value)
        {
            Value = value;
        }
    }
}