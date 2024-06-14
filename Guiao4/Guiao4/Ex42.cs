using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao4
{
    internal class Ex42
    {
            public static void ManipularFrase(string frase)
            {
                int caracteresNumericos = 0;
                int espacos = 0;
                bool apenasMinusculas = true;
                string fraseSemEspacosMultiplos = "";
                bool palindromo = true;

                // Contadores para caracteres numéricos e espaços
                foreach (char c in frase)
                {
                    if (char.IsDigit(c))
                    {
                        caracteresNumericos++;
                    }
                    else if (char.IsWhiteSpace(c))
                    {
                        espacos++;
                    }
                    else if (!char.IsLower(c) && !char.IsWhiteSpace(c))
                    {
                        apenasMinusculas = false;
                    }
                }

                // Remover múltiplos espaços da string
                StringBuilder sb = new StringBuilder();
                bool ultimoEraEspaco = false;
                foreach (char c in frase)
                {
                    if (char.IsWhiteSpace(c))
                    {
                        if (!ultimoEraEspaco)
                        {
                            sb.Append(c);
                        }
                        ultimoEraEspaco = true;
                    }
                    else
                    {
                        sb.Append(c);
                        ultimoEraEspaco = false;
                    }
                }
                fraseSemEspacosMultiplos = sb.ToString().Trim();

                // Verificar se a frase é um palíndromo
                string fraseFormatada = RemoverEspacosPunctuation(frase.ToLower());
                for (int i = 0; i < fraseFormatada.Length / 2; i++)
                {
                    if (fraseFormatada[i] != fraseFormatada[fraseFormatada.Length - 1 - i])
                    {
                        palindromo = false;
                        break;
                    }
                }

                // Exibir os resultados
                Console.WriteLine($"Número de caracteres numéricos: {caracteresNumericos}");
                Console.WriteLine($"Número de espaços: {espacos}");
                Console.WriteLine($"A frase contém apenas minúsculas: {apenasMinusculas}");
                Console.WriteLine($"Frase com espaços múltiplos substituídos por um único espaço: {fraseSemEspacosMultiplos}");
                Console.WriteLine($"A frase é um palíndromo: {palindromo}");
            }

            // Método para remover espaços e pontuações da string
            static string RemoverEspacosPunctuation(string input)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in input)
                {
                    if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
                    {
                        sb.Append(c);
                    }
                }
                return sb.ToString();
            }
        }
    }



