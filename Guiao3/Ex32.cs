using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex32
    {
        public void retroceder()
        {

            //Desenvolva um programa que imprima uma contagem decrescente(até 0) a partir
            //de um valor inteiro positivo N, introduzido pelo utilizador usando o teclado.
            //Exemplo de output para N = 5: 5, 4, 3, 2, 1, 0.

            Console.Write("Insira um numero: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = n; i >= 0; --i)
            {
                if (i != 0)
                {
                    Console.Write($"{i},");
                }
                else
                {
                    Console.Write($"{i}.");
                }

            }

        }
    }
}
