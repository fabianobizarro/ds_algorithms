using DataStructures.Core;
using System;
using System.Text;

namespace DataStructures.ConsoleApp
{
    public static class StackExecution
    {
        public static void Execute()
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.IsEmpty);

            Console.WriteLine("thats all");
            Console.ReadKey();

        }
    }
}
