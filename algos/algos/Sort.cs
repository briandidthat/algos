using System.Linq;

namespace algos
{
    public class Sort
    {
        public static void BubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;

            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    // if element at index j is > element at j + 1, swap them
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
        }

        public static void CountingSort(int[] arr)
        {
            // get the min & max val in the array to define range of values
            int min = arr.Min(), max = arr.Max();

            // create new array that can fit the range of values
            int[] countArray = new int[(max - min) + 1];

            for (int i = 0; i < arr.Length; i++)
                countArray[arr[i] - min]++;

            int j = 0;

            for (int i = min; i <= max; i++)
            {
                while (countArray[i - min] > 0)
                {
                    arr[j++] = i;
                    countArray[i - min]--;
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            // Iterate the array starting at the second index because the
            // element at index 1 is assumed to be in the sorted partition
            for (int i = 0; i < arr.Length; i++) 
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }

                arr[j + 1] = key;
            }
        }

        public static void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // find the middle point of array
                int m = l + (r - l) / 2;

                // sort the first half of array
                MergeSort(arr, l, m);

                // sort the second half of array
                MergeSort(arr, m + 1, r);

                // merge the sorted halves
                Merge(arr, l, m, r);
                
            }
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            // find and define the sizes of the 2 arrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // create temp arrays for data copying
            int[] L = new int[n1];
            int[] R = new int[n2];
            // define iteration variables
            int i, j;

            // copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // reset iteration indices
            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // copy remaining elements of temp L[] array if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // copy remaining elements of temp R[] array if any

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
