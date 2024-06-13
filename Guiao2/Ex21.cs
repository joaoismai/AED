using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao2
{
    internal class Ex21
    {
        public void distancia()
        {
            // Solicita ao usuário para inserir a distância em milhas
            Console.Write("Digite a distância em milhas: ");
            string input = Console.ReadLine();

            // Converte a entrada de string para double
            double milhas;
            bool sucesso = double.TryParse(input, out milhas);

            if (sucesso)
            {
                double quilometros = milhas * 1.60934;


                Console.WriteLine($"{milhas} milhas equivalem a {quilometros} quilômetros.");
            }
            else
            {

                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            }
        }
    }
}
