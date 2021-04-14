using DataStructures.Core;
using System;
using System.Text;

namespace DataStructures.ConsoleApp
{
    public static class QueueExecution
    {
        public static void Execute()
        {
            var queue = new Queue();

            queue.Enqueue(4);
            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(6);

            Console.WriteLine(queue.Peek());
            Console.WriteLine();

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
