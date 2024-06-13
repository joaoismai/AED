using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao3
{
    internal class Ex34
    {
        public void calculos()
        {
            List<double> numeros = new List<double>();
            double primeiroNumero;

            Console.Write("Digite o primeiro número real: ");
            primeiroNumero = double.Parse(Console.ReadLine());
            numeros.Add(primeiroNumero);

            while (true)
            {
                Console.Write("Digite outro número real (ou o mesmo para terminar): ");
                double numero = double.Parse(Console.ReadLine());

                if (numero == primeiroNumero)
                {
                    break;
                }

                numeros.Add(numero);
            }

            double valorMaximo = double.MinValue;
            double valorMinimo = double.MaxValue;
            double soma = 0;
            int totalNumeros = numeros.Count;

            foreach (double num in numeros)
            {
                if (num > valorMaximo)
                {
                    valorMaximo = num;
                }

                if (num < valorMinimo)
                {
                    valorMinimo = num;
                }

                soma += num;
            }

            double media = soma / totalNumeros;


            Console.WriteLine($"Valor máximo: {valorMaximo}");
            Console.WriteLine($"Valor mínimo: {valorMinimo}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Total de números lidos (excluindo o repetido final): {totalNumeros - 1}");
        }
    }
}
