class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int[] vetor = new int[20];

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rand.Next(1, 101);
            Console.Write($"{vetor[i]} - ");
        }

        Console.ReadKey();
        Console.Clear();

        int soma = SomaRecursiva(vetor, vetor.Length - 1);

        Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
    }

    static int SomaRecursiva(int[] vetor, int indice)
    {
        if (indice < 0) 
            return 0;

        return vetor[indice] + SomaRecursiva(vetor, indice - 1);
    }
}