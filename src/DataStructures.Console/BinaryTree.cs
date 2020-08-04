using DataStructures.Core;
using DataStructures.Core.Iterators;
using System;

namespace DataStructures.ConsoleApp
{
    public static class BinaryTreeExecution
    {
        public static void Execute()
        {
            Console.WriteLine("Hello World!");

            var tree = new BinaryTree();

            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(17);
            tree.Insert(14);
            tree.Insert(7);
            tree.Insert(3);

            Console.WriteLine("In Order print");
            foreach (var item in BinaryTreeIterators.InOrder(tree))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Pre Order print");
            foreach (var item in BinaryTreeIterators.PreOrder(tree))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Post Order print");
            foreach (var item in BinaryTreeIterators.PostOrder(tree))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("thats all folks");
            Console.ReadKey();
        }
    }
}
