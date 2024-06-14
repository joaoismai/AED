using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao4
{
    internal class Ex43
    {
        public static string ObterAcronimo(string frase)
        {
            // StringBuilder para construir o acrônimo
            StringBuilder sb = new StringBuilder();

            // Dividir a frase em palavras usando espaços como delimitador
            string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string palavra in palavras)
            {
                // Verificar se a palavra tem 3 ou mais caracteres
                if (palavra.Length >= 3)
                {
                    // Adicionar a primeira letra da palavra ao acrônimo (convertida para maiúscula)
                    sb.Append(char.ToUpper(palavra[0]));
                }
            }

            // Retornar o acrônimo como string
            return sb.ToString();
        }
    }
}
