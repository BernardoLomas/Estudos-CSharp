using System;

class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int[,] matriz = new int[3, 3];

        // Preenchendo a matriz com números aleatórios de 1 a 20
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rand.Next(1, 21);
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int maiorPar = AnalisaMatriz(matriz, 0, 0, int.MinValue);
        Console.WriteLine($"\nO maior número par da matriz é {maiorPar}");
    }

    static int AnalisaMatriz(int[,] matriz, int i, int j, int maior)
    {
        // Caso base: ultrapassou as linhas
        if (i >= matriz.GetLength(0))
            return maior;

        // Atualiza o maior se o número atual for par e maior que o maior atual
        if (matriz[i, j] % 2 == 0 && matriz[i, j] > maior)
            maior = matriz[i, j];

        // Próximo índice da coluna
        if (j + 1 < matriz.GetLength(1))
            return AnalisaMatriz(matriz, i, j + 1, maior);
        else
            // Próxima linha
            return AnalisaMatriz(matriz, i + 1, 0, maior);
    }
}
