using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao2
{
    internal class Ex24
    {
        public void investimento()
        {

            Console.Write("Digite o montante investido em euros: ");
            string inputMontante = Console.ReadLine();

            Console.Write("Digite a taxa de juros mensal (em %): ");
            string inputTaxaJuros = Console.ReadLine();

            double montanteInicial, taxaJuros;
            bool sucessoMontante = double.TryParse(inputMontante, out montanteInicial);
            bool sucessoTaxaJuros = double.TryParse(inputTaxaJuros, out taxaJuros);

            if (sucessoMontante && sucessoTaxaJuros)
            {

                double montanteFinal = montanteInicial;
                for (int i = 0; i < 3; i++)
                {
                    montanteFinal = montanteFinal * (1 + taxaJuros / 100);
                }

                Console.WriteLine($"O montante ao fim de 3 meses será de {montanteFinal:F3} euros.");
            }
            else
            {

                Console.WriteLine("Entrada inválida. Por favor, insira números válidos.");
            }
        }
    }
}
