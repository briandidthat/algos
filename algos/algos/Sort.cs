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
    }
}
