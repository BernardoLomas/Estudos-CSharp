using System;

class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int[] vetor = new int[10];

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rand.Next(1, 101);
            Console.Write($"{vetor[i]} - ");
        }

        Console.WriteLine();

        int indice = vetor.Length - 1; 

        int pares = ContaPares(vetor, indice);

        Console.WriteLine($"A quantidade de números pares no vetor é igual a {pares}");
    }

    static int ContaPares(int[] vetor, int indice)
    {
        if (indice < 0) 
            return 0;

        if (vetor[indice] % 2 == 0)
            return 1 + ContaPares(vetor, indice - 1);
        else
            return ContaPares(vetor, indice - 1);
    }
}
