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

                // If x is greater than mid, ignore right half 
                if (arr[mid] < x)
                    return BinarySearch(arr, mid + 1, r, x);

                // If x less than mid, ignore left half 
                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);


            }

            return -1;
        }

        /// <summary>Iterative Binary search implementation.</summary>
        /// <returns>Element index or -1 if not present.</returns>
        public static int BinarySearch(int[]arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid 
                if (arr[m] == x)
                    return m;

                // If x greater than mid, ignore left half 
                if (arr[m] < x)
                    l = m + 1;

                // If x is less than mid, ignore right half 
                else
                    r = m - 1;
            }

            return -1;
        }
    }
}
