using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao7
{
    internal class _74
    {
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            int pivot = array[left];
            int partition = Partition(array, left, right, pivot);

            QuickSort(array, left, partition);
            QuickSort(array, partition + 1, right);
        }

        public static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left < right)
            {
                while (array[left] < pivot)
                    left++;

                while (array[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
            }

            return left;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }



    }
}
