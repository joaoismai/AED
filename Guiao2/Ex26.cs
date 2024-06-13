using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex26
    {
        public void conversao()
        {

            Console.Write("Insira um valor em segundos: ");
            int totalsegundos = int.Parse(Console.ReadLine());

            int horas = totalsegundos / 3600;
            int minutos = (totalsegundos % 3600)/60;
            int segundos = totalsegundos % 60;

            string formatodata = $"{horas:D2}:{minutos:D2}:{segundos:D2}";

            Console.WriteLine($"Tempo correspondente: {formatodata}");
        }

    }
}
