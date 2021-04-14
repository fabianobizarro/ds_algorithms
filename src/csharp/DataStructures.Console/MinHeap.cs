using DataStructures.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.ConsoleApp
{
    public class MinHeapExecution
    {
        public void Execute()
        {
            var heap = new MinHeap();

            heap.Insert(10);
            heap.Insert(15);
            heap.Insert(20);
            heap.Insert(13);
            heap.Insert(25);
            heap.Insert(11);
            heap.Insert(1);

            Print(heap);

            Console.WriteLine($"removing item {heap.Delete()}");

            Print(heap);

            Console.WriteLine("thats all folks");
            Console.ReadLine();
        }

        private static void Print(MinHeap heap)
        {
            foreach (var item in heap.Items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
