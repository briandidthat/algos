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
            int min = arr.Min();
            int max = arr.Max();
            int[] countArray = new int[(max - min) + 1];

            for (int i = 0; i < arr.Length; i++)
            {   
                countArray[arr[i] - min]++;
            }

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
    }
}
