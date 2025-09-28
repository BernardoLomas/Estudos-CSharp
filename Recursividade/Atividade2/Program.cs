using System;

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

        Console.WriteLine(); 

        int menor = MenorDoVetor(vetor, vetor.Length - 1);
        Console.WriteLine($"O menor valor do vetor é: {menor}");
    }

    static int MenorDoVetor(int[] vetor, int indice)
    {
        // Caso base: chegou no primeiro elemento
        if (indice == 0)
            return vetor[0];

        // Chama recursivamente para os anteriores
        int menorAnterior = MenorDoVetor(vetor, indice - 1);

        // Retorna o menor entre o atual e o menor encontrado antes
        return vetor[indice] < menorAnterior ? vetor[indice] : menorAnterior;
    }
}
