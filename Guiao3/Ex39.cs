using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex39
    {
        public void notas()
        {
            const int numAlunos = 4; // Número de alunos
            const int numComponentes = 2; // Número de componentes (teórica e prática)

            // Inicializa a matriz de notas com valores aleatórios entre 0.0 e 20.0
            double[,] notas = new double[numAlunos, numComponentes];
            Random random = new Random();

            for (int aluno = 0; aluno < numAlunos; aluno++)
            {
                for (int componente = 0; componente < numComponentes; componente++)
                {
                    notas[aluno, componente] = random.NextDouble() * 20.0;
                }
            }

            // Calcula a nota final para cada aluno
            double[] notasFinais = new double[numAlunos];
            for (int aluno = 0; aluno < numAlunos; aluno++)
            {
                double notaT = notas[aluno, 0]; // Componente teórica
                double notaP = notas[aluno, 1]; // Componente prática
                notasFinais[aluno] = 0.4 * notaT + 0.6 * notaP;
            }

            // Exibe as notas finais
            for (int aluno = 0; aluno < numAlunos; aluno++)
            {
                Console.WriteLine($"Aluno {aluno + 1}: Nota final = {notasFinais[aluno]:F2}");
            }
        }
    }
}
