using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao1
{
    internal class Ex13
    {
        public List<int> ObterMultiplosDeDois()
        {
            // Solicita ao usuário o número de elementos do vetor
            Console.Write("Quantos números você deseja inserir? ");
            int tamanho = int.Parse(Console.ReadLine());

            // Inicializa o vetor com o tamanho especificado pelo usuário
            int[] numeros = new int[tamanho];

            // Solicita ao usuário para preencher o vetor
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Inicializa uma lista para armazenar os múltiplos de 2
            List<int> multiplosDeDois = new List<int>();

            // Percorre o array e adiciona os números que são múltiplos de 2 à lista
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    multiplosDeDois.Add(numero);
                }
            }

            // Retorna a lista de múltiplos de 2
            return multiplosDeDois;
        }
    }
}
