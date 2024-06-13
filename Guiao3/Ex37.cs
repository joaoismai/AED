using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicios
{
    internal class Ex37
    {
        public void saida()
        {
            Console.Write("Digite o número do mês (1 a 12): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            if (mes >= 1 && mes <= 12)
            {
                int dias = CalcularDiasDoMes(mes, ano);
                Console.WriteLine($"O mês {mes} do ano {ano} tem {dias} dias.");
            }
            else
            {
                Console.WriteLine("Mês inválido. Digite um número entre 1 e 12.");
            }

            static int CalcularDiasDoMes(int mes, int ano)
            {
                if (mes == 2)
                {
                    if (AnoBissexto(ano))
                        return 29;
                    else
                        return 28;
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    return 30;
                }
                else
                {
                    return 31;
                }
            }

            static bool AnoBissexto(int ano)
            {
                return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
            }

        }
    }
}
