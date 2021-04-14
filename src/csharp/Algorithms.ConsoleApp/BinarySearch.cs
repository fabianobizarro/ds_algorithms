using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms.Core;

namespace Algorithms.ConsoleApp
{
    public static class BinarySearchExecution
    {
        private static int[] CreateArray()
        {
            return new int[]
            {
                6,
                7,
                8,
                9,
                10,
                11,
                14,
                15,
                17,
                19,
                23
            }.OrderBy(p => p).ToArray();
        }

        private static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }


        public static void Execute()
        {
            Console.WriteLine("Hello World!");

            int[] array = CreateArray();

            Console.WriteLine("Array");
            Print(array);

            var target = 7;

            //Iterations = 0;
            Console.WriteLine($"binary search found {target}: {BinarySearch.Search(array, target)} / Iterations: {0}");

            //Iterations = 0;
            Console.WriteLine($"binary search recursive found {target}: {BinarySearch.RecursiveSearch(array, target)} / iterations {0}");

            Console.WriteLine("done");
        }
    }
}
