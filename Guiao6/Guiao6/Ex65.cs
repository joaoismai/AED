using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao6
{
    internal class Ex65
    {
        public void Hashtable()
        {

             Hashtable hashtable = new Hashtable();
        hashtable.Add("chave1", "valor1");
        hashtable.Add("chave2", "valor2");
        // Adicione mais pares chave-valor conforme necessário

        // Acesse valores pela chave:
        Console.WriteLine(hashtable["chave1"]); // Imprime "valor1"
            }
    }
}
