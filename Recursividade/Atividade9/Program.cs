using System;

class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Matriz gerada:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rand.Next(1, 21);
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Diagonal principal:");
        MostraDiagonal(matriz, 0);

        int soma = SomaDiagonal(matriz, 0);
        Console.WriteLine($"\nA soma da diagonal principal é: {soma}");
    }

    static void MostraDiagonal(int[,] matriz, int i)
    {
        if (i >= matriz.GetLength(0))
            return;

        Console.WriteLine(matriz[i, i]);
        MostraDiagonal(matriz, i + 1);
    }

    static int SomaDiagonal(int[,] matriz, int i)
    {
        if (i >= matriz.GetLength(0))
            return 0;

        return matriz[i, i] + SomaDiagonal(matriz, i + 1);
    }
}
