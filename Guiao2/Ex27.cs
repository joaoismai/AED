using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex27
    {
        public void distancia()

        {
            Console.Write("Insira as coordenadas x do p1: ");
            double xp1 = double.Parse(Console.ReadLine());
            Console.Write("Insira as coordenadas y do p1: ");
            double yp1 = double.Parse(Console.ReadLine());

            Console.Write("Insira as coordenadas x do p2: ");
            double xp2 = double.Parse(Console.ReadLine());
            Console.Write("Insira as coordenadas y do p2: ");
            double yp2 = double.Parse(Console.ReadLine());

            double distancia = Math.Sqrt(Math.Pow(xp2 - xp1, 2) + Math.Pow(yp2 - yp1, 2));

            Console.WriteLine($"Valor distancia = {distancia}");


        }
    }
}
