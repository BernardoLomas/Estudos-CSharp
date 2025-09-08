using System;

class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[2, 5];
        Random rand = new Random();

        
        Console.WriteLine("Matriz original:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rand.Next(1, 10); 
                Console.Write($"{matriz[i, j],5}");
            }
            Console.WriteLine();
        }

        Console.Write("\nDigite o valor do escalar K: ");
        int K = int.Parse(Console.ReadLine());


        int[,] matrizK = MultiplicaEscalar(matriz, K);


        Console.WriteLine($"\nMatriz multiplicada por {K}:");
        for (int i = 0; i < matrizK.GetLength(0); i++)
        {
            for (int j = 0; j < matrizK.GetLength(1); j++)
            {
                Console.Write($"{matrizK[i, j],5}");
            }
            Console.WriteLine();
        }
    }

    static int[,] MultiplicaEscalar(int[,] matriz, int K)
    {
        int[,] resultado = new int[matriz.GetLength(0), matriz.GetLength(1)];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                resultado[i, j] = matriz[i, j] * K;
            }
        }

        return resultado;
    }
}
