using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex28
    {
        public void hipotenusa()
        {


            Console.Write("Insira o valor do A cateto: ");
            double cA = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor do B cateto: ");
            double cB = float.Parse(Console.ReadLine());

            double hip = Math.Sqrt((cA * cA) + (cB * cB));

            hip = Math.Round(hip, 2);

            Console.WriteLine($"A hipotenusa do triângulo é: {hip}");

            double anguloRad = Math.Asin(cA / hip);
            double anguloGraus = anguloRad * (180.0 / Math.PI);

            anguloGraus = Math.Round(anguloGraus, 2); /*limitar casas decimais de um valor double*/

            Console.WriteLine($"O ângulo entre o lado A e a hipotenusa é aproximadamente {anguloGraus} graus.");

        }
    }
}
