using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao7
{
    internal class _73
    {
        public static int BubbleSort(int[] arr)
        {
            int iterations = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    iterations++;
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
            return iterations;
        }

        public static int InsertionSort(int[] arr)
        {
            int iterations = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    iterations++;
                    Swap(arr, j, j - 1);
                    j--;
                }
            }
            return iterations;
        }

        public static void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
