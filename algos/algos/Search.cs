using System;
namespace algos
{
    public class Search
    {
        /// <summary>Recursive Binary search implementation</summary>
        /// <returns>Element index or -1 if not present.</returns>
        public static int BinarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // Check if x is present at mid 
                if (arr[mid] == x)
                    return mid;

                // If mid element is less than x, ignore left half 
                if (arr[mid] < x)
                    return BinarySearch(arr, mid + 1, r, x);

                // If mid element is greater than x, ignore right half 
                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);


            }

            return -1;
        }

        /// <summary>Iterative Binary search implementation.</summary>
        /// <returns>Element index or -1 if not present.</returns>
        public static int BinarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid 
                if (arr[m] == x)
                    return m;

                // If mid element is less than x, ignore left half 
                if (arr[m] < x)
                    l = m + 1;

                // If mid element is greater than x, ignore right half 
                else
                    r = m - 1;
            }

            return -1;
        }

        /// <summary>Iterative search implementation for 1D array.</summary>
        /// <returns>Element index or -1 if not present.</returns>
        public static int LinearSearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>Iterative search implementation for 2D rectangular array.</summary>
        /// <returns>Element index array or [-1, -1] if not present.</returns>
        public static int[] LinearSearch(int[,] arr, int x)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(i); j++)
                {
                    if (arr[i, j] == x)
                    {
                        return new int[] { i, j};
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        /// <summary>Iterative search implementation for 2D jagged array.</summary>
        /// <returns>Element index array or [-1, -1] if not present.</returns>
        public static int[] LinearSearch(int[][] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == x)
                    {
                        return new int[] { i, j }; 
                    }
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
