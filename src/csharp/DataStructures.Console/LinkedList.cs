using DataStructures.Core;
using System;
using System.Text;

namespace DataStructures.ConsoleApp
{
    public class LinkedListExecution
    {
        public void Execute()
        {

            var list = new LinkedList();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);

            PrintList(list);

            list.Prepend(9);
            list.Append(5);


            PrintList(list);

            list.Delete(4);
            list.Delete(9);
            list.Delete(5);

            PrintList(list);


            Console.WriteLine("end");
            Console.ReadKey();

        }

        private static void PrintList(LinkedList list)
        {
            var current = list.Head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }
    }


    public class DoublyLinkedListExecution
    {
        public void Execute()
        {
            var list = new LinkedList();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);

            PrintList(list);

            list.Prepend(9);
            list.Append(5);


            PrintList(list);

            list.Delete(4);
            list.Delete(9);
            list.Delete(5);

            PrintList(list);


            Console.WriteLine("end");
            Console.ReadKey();
        }

        private static void PrintList(LinkedList list)
        {
            var current = list.Head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
