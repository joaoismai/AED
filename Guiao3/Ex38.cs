using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex38
    {
        public void adivinha()
        {
            Random random = new Random();
            int numeroEscolhido = random.Next(101); // Gera um número aleatório entre 0 e 100

            int tentativas = 0;
            int palpite;

            do
            {
                Console.Write("Tente adivinhar o número (0 a 100): ");
                palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite < numeroEscolhido)
                    Console.WriteLine("Tente um número maior.");
                else if (palpite > numeroEscolhido)
                    Console.WriteLine("Tente um número menor.");
                else
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");

            } while (palpite != numeroEscolhido);

            Console.Write("Deseja continuar a jogar? (s/n): ");
            char resposta = char.ToLower(Console.ReadKey().KeyChar);

            if (resposta == 's')
            {
                Console.WriteLine("\nVamos lá!");
                adivinha(); // Reinicia o jogo
            }
            else
            {
                Console.WriteLine("\nObrigado por jogar! Até a próxima.");
            }
        }
    }
}
