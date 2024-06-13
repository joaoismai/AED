using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao3
{
    internal class Ex33
    {
        public void primo()
        {
            int numero;

            while (true)
            {
                Console.Write("Digite um número inteiro positivo: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero) && numero > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro positivo.");
                }
            }

            bool ehPrimo = EhNumeroPrimo(numero);
            if (ehPrimo)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }

        static bool EhNumeroPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
