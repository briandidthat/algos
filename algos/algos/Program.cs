using System;

namespace algos
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 2, 9, 11, 14, 15, 17, 22, 25, 26, 46, 63, 72, 82, 92 };
            int n = array.Length;
            int x = 63;

            int recursiveResult = Search.BinarySearch(array, 0, n - 1, x);
            int iterativeResult = Search.BinarySearch(array, x);

            Console.WriteLine("ITERATIVE SEARCH");

            if (iterativeResult == -1)
                Console.WriteLine("Element not present in array.");
            else
                Console.WriteLine($"Element found at index: {iterativeResult}");

            Console.WriteLine("RECURSIVE SEARCH");

            if (recursiveResult == -1)
                Console.WriteLine("Element not present in array.");
            else
                Console.WriteLine($"Element found at index: {recursiveResult}");
        }
    }
}
