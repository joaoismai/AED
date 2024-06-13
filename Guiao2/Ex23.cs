using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao2
{
    internal class Ex23
    {
        public void agua()
        {

            Console.Write("Digite a quantidade de água em kg: ");
            string inputM = Console.ReadLine();


            Console.Write("Digite a temperatura inicial em graus Celsius: ");
            string inputTempInicial = Console.ReadLine();


            Console.Write("Digite a temperatura final em graus Celsius: ");
            string inputTempFinal = Console.ReadLine();


            double M, temperaturaInicial, temperaturaFinal;
            bool sucessoM = double.TryParse(inputM, out M);
            bool sucessoTempInicial = double.TryParse(inputTempInicial, out temperaturaInicial);
            bool sucessoTempFinal = double.TryParse(inputTempFinal, out temperaturaFinal);

            if (sucessoM && sucessoTempInicial && sucessoTempFinal)
            {

                double Q = M * (temperaturaFinal - temperaturaInicial) * 4184;

                Console.WriteLine($"A energia necessária para aquecer {M} kg de água de {temperaturaInicial}°C para {temperaturaFinal}°C é {Q} Joules.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira números válidos.");
            }
        }
    }
}
