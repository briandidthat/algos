using System;
using System.Linq;

namespace algos
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 63, 72, 92, 2, 9, 11, 22, 46, 25, 26, 82, 16, 17, 1 };
            int[,] rectangle = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
            int[][] jagged = { new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 } };


            Console.WriteLine(string.Join("-", array));

            Sort.MergeSort(array, 0, array.Length - 1);

            Console.WriteLine(string.Join("-", array));
        }
    }
}
