using DataStructures.Core.Nodes;

namespace DataStructures.Core
{
    public class BinaryTree
    {
        public BinaryTreeNode Root { get; private set; }

        public void Insert(int value)
        {
            if (Root == null)
                Root = new BinaryTreeNode(value);
            else
                Root.Insert(value);
        }

        public BinaryTreeNode Search(int value)
        {
            return Root.Search(value);
        }
    }
}
