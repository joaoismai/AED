using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex36
    {
        public void montante()
        {

            double montanteInvestido;

            do
            {
                Console.Write("Informe o montante investido (múltiplo de 1000): ");
                if (!double.TryParse(Console.ReadLine(), out montanteInvestido))
                {
                    Console.WriteLine("Valor inválido. Insira um número válido.");
                    continue;
                }

                if (montanteInvestido <= 0 || montanteInvestido % 1000 != 0)
                {
                    Console.WriteLine("Montante inválido. Deve ser positivo e múltiplo de 1000.");
                }
            } while (montanteInvestido <= 0 || montanteInvestido % 1000 != 0);

            // Solicita a taxa de juro mensal (entre 0% e 5%)
            Console.Write("Informe a taxa de juro mensal (em decimal, ex: 0.03 para 3%): ");
            double taxaJuroMensal = double.Parse(Console.ReadLine());

            // Verifica se a taxa de juro é válida
            if (taxaJuroMensal < 0 || taxaJuroMensal > 0.05)
            {
                Console.WriteLine("Taxa de juro inválida. Deve estar entre 0% e 5%.");
                return;
            }

            // Calcula o valor mensal do fundo nos próximos 12 meses
            double[] valoresMensais = new double[12];
            double saldo = montanteInvestido;

            for (int mes = 0; mes < 12; mes++)
            {
                valoresMensais[mes] = saldo * (1 + taxaJuroMensal);
                saldo = valoresMensais[mes];
            }

            // Apresenta os valores mensais
            Console.WriteLine("\nValores mensais do fundo nos próximos 12 meses:");
            for (int mes = 0; mes < 12; mes++)
            {
                Console.WriteLine($"Mês {mes + 1}: {valoresMensais[mes]:C2}");
            }
        }
    }
}
