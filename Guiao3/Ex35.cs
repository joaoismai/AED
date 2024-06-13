using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex35
    {
        public void inversa()
        {


            Console.WriteLine("Insira o tamanho do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vet = new int[tamanho];

            Console.WriteLine("\n");
            for (int i = 0; i < tamanho; i++)
            {

                Console.Write($"Insira o valor da {i + 1} posição: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray na ordem inversa:");
            for (int i = tamanho - 1; i >= 0; i--)
            {

                Console.WriteLine($"Valor da {i + 1} posição = {vet[i]}");

            }


        }
    }
}
