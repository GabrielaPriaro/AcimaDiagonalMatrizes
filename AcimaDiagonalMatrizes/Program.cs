//Utilizando matrizes:
//Problema "acima_diagonal"
//Ler um inteiro N (máximo = 10) e uma matriz quadrada de ordem N
//contendo números inteiros. Mostrar a soma dos elementos acima da diagonal principal.

namespace AcimaDiagonalMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, somaAcimaDiagonal = 0;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i +1; j < n; j++)
                {
                    somaAcimaDiagonal = somaAcimaDiagonal + mat[i, j];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = {somaAcimaDiagonal}");
        }
    }
}
