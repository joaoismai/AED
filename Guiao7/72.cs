using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao7
{
    internal class _72
    {
        public static int BubbleSort(int[] arr)
        {
            int temp;
            bool swapped;
            int iterations = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    iterations++;

                    if (arr[j] > arr[j + 1])
                    {
                        // Troca os elementos
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // Se nenhum elemento foi trocado, o array já está ordenado
                if (!swapped)
                    break;
            }

            return iterations;
        }
    }
}
