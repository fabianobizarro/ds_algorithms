using System;
using System.Linq;

namespace Algorithms.ConsoleApp
{
    public static class SortingExecution
    {
        public static void Execute()
        {
            var array = CreateMockArray();

            Print(array);
            
            //QuickSort.Sort(array);
            //new MergeSort().Sort(array);
            //BubbleSort.Sort(array);
            //InsertionSort.Sort(array);
            //SelectionSort.Sort(array);
            //ShellSort.Sort(array);
            //HeapSort.Sort(array);

            Print(array);
        }

        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static int[] CreateRandomArray(int size)
        {
            var random = new Random(64564);
            return Enumerable.Repeat(0, size)
                .Select(p => random.Next(0, 100))
                .ToArray();
        }

        private static int[] CreateMockArray()
        {
            return new int[]
            {
                10,
                8,
                7,
                6,
                12,
            };
        }
    }
}
