class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int [3,3];
        Random x = new Random();

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = x.Next(1, 50);
            }
        }

        int[] A = Diagonal(matriz);
        Console.WriteLine($"Vetor com os elementos fora da diagonal principal: ");
        Console.Write(string.Join(" - ", A));


    }

    static int[] Diagonal(int[,] matriz)
    {
        int[] vetor = new int[6];
        int k = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i != j)
                {
                    vetor[k] = matriz[i, j];
                    k++;
                }
            }
        }

        return vetor;
    }
}