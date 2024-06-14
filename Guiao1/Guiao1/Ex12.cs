using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao1
{
    internal class Ex12
    {

            public void ObterNumeroMaisAlto()
            {
                Console.Write("Quantos números você deseja inserir? ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] numeros = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write($"Digite o número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                if (numeros == null || numeros.Length == 0)
                {
                    throw new ArgumentException("O array não pode estar vazio ou ser nulo.");
                }

                int numeroMaisAlto = numeros[0];

                foreach (int numero in numeros)
                {
                    if (numero > numeroMaisAlto)
                    {
                        numeroMaisAlto = numero;
                    }
                }


            Console.WriteLine("O número mais alto é: " + numeroMaisAlto);
        }
    }   
}
