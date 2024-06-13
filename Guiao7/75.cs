using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao7
{
    internal class _75
    {
        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        public static void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[middle + 1 + j];

            int k = left;
            int p = 0, q = 0;

            while (p < n1 && q < n2)
            {
                if (leftArray[p] <= rightArray[q])
                    array[k++] = leftArray[p++];
                else
                    array[k++] = rightArray[q++];
            }

            while (p < n1)
                array[k++] = leftArray[p++];
            while (q < n2)
                array[k++] = rightArray[q++];
        }

        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
