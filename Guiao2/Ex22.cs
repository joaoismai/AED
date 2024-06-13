using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao2
{
    internal class Ex22
    {
        public void graus()
        {


            Console.Write("Digite a temperatura em graus Fahrenheit: ");
        string input = Console.ReadLine();


        double fahrenheit;
        bool sucesso = double.TryParse(input, out fahrenheit);
        
        if (sucesso)
        {

            double celsius = (fahrenheit - 32) / 1.8;

        Console.WriteLine($"{fahrenheit} graus Fahrenheit equivalem a {celsius} graus Celsius.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
        }
        }
    }
}
