using System.Collections;

namespace Guiao7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Exercicio 7.1
                int[] intArray = new int[5];
                Console.WriteLine("Introduza os elementos do array:");
                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = int.Parse(Console.ReadLine());
                }

                _71.Sort(intArray);

                Console.WriteLine("Array ordenado:");
                foreach (int item in intArray)
                {
                    Console.Write(item + " ");
                }

                Console.ReadKey();
            */



            /*Exercicio 7.2
                int[] intArray = { 64, 34, 25, 12, 22, 11, 90 };

                // Bubble Sort com otimização
                int iterations = _72.BubbleSort(intArray);

                Console.WriteLine("Array ordenado:");
                foreach (int item in intArray)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine($"\nNúmero de iterações: {iterations}");
                Console.ReadKey();

                }
            */




            /*Exercicio 7.3
                int[] intArray = { 86, 13, 60, 46, 73, 52 };

                // Bubble Sort
                int bubbleSortIterations = _73.BubbleSort(intArray);
                Console.WriteLine("Bubble Sort - Array ordenado:");
                _73.PrintArray(intArray);
                Console.WriteLine($"Número de iterações (Bubble Sort): {bubbleSortIterations}");

                // Insertion Sort
                int[] intArrayCopy = { 86, 13, 60, 46, 73, 52 };
                int insertionSortIterations = _73.InsertionSort(intArrayCopy);
                Console.WriteLine("\nInsertion Sort - Array ordenado:");
                _73.PrintArray(intArrayCopy);
                Console.WriteLine($"Número de iterações (Insertion Sort): {insertionSortIterations}");

                Console.ReadKey();
            */



            /*Exercicio 7.4
                int[] inputArray = { 5, 2, 9, 1, 5, 6 };

                Console.WriteLine("Input do vetor:");
                _74.PrintArray(inputArray);

                _74.QuickSort(inputArray, 0, inputArray.Length - 1); //O método QuickSort é chamado para ordenar o array.

                Console.WriteLine("\nArray ordenado:");
                _74.PrintArray(inputArray);
            */



            /*Exercicio 7.5
                int[] inputArray = { 5, 2, 9, 1, 5, 6 };

                Console.WriteLine("Input do vetor:");
                _75.PrintArray(inputArray);

                _75.MergeSort(inputArray, 0, inputArray.Length - 1);

                Console.WriteLine("\nVetor ordenado:");
                _75.PrintArray(inputArray);
            */





        }
    }
}
