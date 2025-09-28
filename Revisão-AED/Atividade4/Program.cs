using System;

class Program
{
    private static void Main(string[] args)
    {
        int[] A = new int[10];
        int[] B = new int[10];
        int[] C = new int[10];
        Random rand = new Random();


        for (int i = 0; i < A.Length; i++)
        {
            A[i] = rand.Next(1, 50);
            B[i] = rand.Next(1, 50);
        }


        for (int i = 0; i < C.Length; i++)
        {
            C[i] = A[i] + B[i];
        }


        Console.WriteLine("Vetor A: " + string.Join(" - ", A));
        Console.WriteLine("Vetor B: " + string.Join(" - ", B));
        Console.WriteLine("Soma (Vetor C): " + string.Join(" - ", C));
    }
}
