using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex31
    {
        public void notas()
        {
            Console.Write("Digite a nota da componente prática (notaP): ");
            double notaP = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da componente teórica (notaT): ");
            double notaT = double.Parse(Console.ReadLine());

            //Verificar se as notas estão no intervalo [0, 20]
            if (notaP < 0 || notaP > 20 || notaT < 0 || notaT > 20)
            {
                Console.WriteLine("As notas devem estar no intervalo [0, 20].");
            }

            // Calcula a nota final
            double notaFinal = 0.4 * notaT + 0.6 * notaP;

            // Verifica se o aluno foi reprovado por nota mínima
            if (notaP < 6.0 || notaT < 6.0)
            {
                Console.WriteLine("Reprovado por nota mínima (66).");
            }
            else
            {
                // Arredonda a nota final para a unidade mais próxima
                int notaFinalArredondada = (int)Math.Round(notaFinal);

                Console.WriteLine($"Nota final: {notaFinalArredondada}");

            }
        }
    }
}
