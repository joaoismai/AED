using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao4
{
    internal class Ex41
    {
        public void ManipularString()
        {

            Console.Write("Digite uma palavra, frase ou parágrafo: ");
            string input = Console.ReadLine();


            string minusculas = input.ToLower();
            Console.WriteLine("String convertida para minúsculas: " + minusculas);

            char ultimoCaractere = input[input.Length - 1];
            Console.WriteLine("Último caractere: " + ultimoCaractere);


            string tresPrimeirosCaracteres = input.Substring(0, Math.Min(3, input.Length));
            Console.WriteLine("Os 3 primeiros caracteres: " + tresPrimeirosCaracteres);


            bool contemTeste = input.Contains("teste");
            Console.WriteLine("A string contém a palavra 'teste': " + contemTeste);


            string substituida = input.Replace('a', 'x');
            Console.WriteLine("String com 'a' substituído por 'x': " + substituida);


            string semEspacos = input.Trim();
            Console.WriteLine("String sem espaços no início e no final: " + semEspacos);


            bool comecaCom = input.StartsWith("Hello");
            Console.WriteLine("A string começa com 'Hello': " + comecaCom);


            bool terminaCom = input.EndsWith("World");
            Console.WriteLine("A string termina com 'World': " + terminaCom);
        }
    }
}
