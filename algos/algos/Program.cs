using System;

namespace algos
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 63, 72, 92, 2, 9, 11, 22, 46, 25, 26, 82, 16, 17, 1 };
            int n = array.Length;

            Console.WriteLine(string.Join("-", array));

            Sort.BubbleSort(array, n);

            Console.WriteLine(string.Join("-", array));
        }
    }
}
