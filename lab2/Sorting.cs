using System.Collections.Generic;
using System.Text;

namespace lab2
{
    internal class Sorting
    {
        private static void recordSteps(int[] arr, int n, List<string> steps)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n - 1; i++)
                sb.Append(arr[i] + ", ");
            sb.Append(arr[n - 1] + "\n");

            steps.Add(sb.ToString());
        }

        // Time complexity: O(N^2)
        public static void bubbleSort(int[] arr, int n, List<string> steps)
        {
            steps.Add("\tBubble sort");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                recordSteps(arr, n, steps);
            }
        }


        // Time complexity: O(N^2)
        public static void selectionSort(int[] arr, int n, List<string> steps)
        {
            steps.Add("\tSelection sort");
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[minIndex]) minIndex = j;

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;

                recordSteps(arr, n, steps);
            }
        }

        // Time Complexity: O(N^2) 
        public static void insertionSort(int[] arr, int n, List<string> steps)
        {
            steps.Add("\tInsertion sort");
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = key;

                recordSteps(arr, n, steps);
            }
        }
    }
}