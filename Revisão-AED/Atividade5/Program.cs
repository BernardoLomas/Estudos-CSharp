class Program
{
    private static void Main(string[] args)
    {
        int[,] m1 = new int[3, 3];
        int[,] m2 = new int[3, 3];
        

        var (resultante, diferenca) = SomaMatrizes(m1, m2);

        Console.WriteLine("<=== MATRIZ DA SOMA ===> ");
        for (int i = 0; i < m1.GetLength(0); i++)
        {
            for (int j = 0; j < m1.GetLength(1); j++)
            {
                Console.Write($"{resultante[i, j],5}");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"<=== MATRIZ DE DIFERENÇA ===>");
        for (int i = 0; i < m1.GetLength(0); i++)
        {
            for (int j = 0; j < m1.GetLength(1); j++)
            {
                Console.Write($"{diferenca[i, j],5}");
            }
            Console.WriteLine();
        }

    }

    static (int[,] resultante, int[,] diferenca) SomaMatrizes(int[,] m1, int[,] m2)
    {
        int[,] resultante = new int[m1.GetLength(0), m1.GetLength(1)];
        int[,] diferenca = new int[m1.GetLength(0), m1.GetLength(1)];
        Random x = new Random();

        for (int i = 0; i < m1.GetLength(0); i++)
        {
            for (int j = 0; j < m1.GetLength(1); j++)
            {
                m1[i, j] = x.Next(1, 50);
                m2[i, j] = x.Next(1, 50);
                resultante[i, j] = m1[i, j] + m2[i, j];
                diferenca[i, j] = m1[i, j] - m2[i, j];
            }
        }

        return (resultante, diferenca);
    }
}
