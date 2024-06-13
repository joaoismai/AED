using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao2
{
    internal class Ex25
    {
        public void viagem()
        {

            Console.Write("Digite o tempo gasto no primeiro trajeto (em horas): ");
            string inputT1 = Console.ReadLine();

            Console.Write("Digite a distância percorrida no primeiro trajeto (em km): ");
            string inputD1 = Console.ReadLine();


            Console.Write("Digite o tempo gasto no segundo trajeto (em horas): ");
            string inputT2 = Console.ReadLine();

            Console.Write("Digite a distância percorrida no segundo trajeto (em km): ");
            string inputD2 = Console.ReadLine();


            double t1, d1, t2, d2;
            bool sucessoT1 = double.TryParse(inputT1, out t1);
            bool sucessoD1 = double.TryParse(inputD1, out d1);
            bool sucessoT2 = double.TryParse(inputT2, out t2);
            bool sucessoD2 = double.TryParse(inputD2, out d2);

            if (sucessoT1 && sucessoD1 && sucessoT2 && sucessoD2)
            {

                double distanciaTotal = d1 + d2;
                double tempoTotal = t1 + t2;


                double velocidadeMedia = distanciaTotal / tempoTotal;


                Console.WriteLine($"A velocidade média final é de {velocidadeMedia:F2} km/h.");
            }
            else
            {

                Console.WriteLine("Entrada inválida. Por favor, insira números válidos.");
            }
        }
    }
}
