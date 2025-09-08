using System;

class Program
{
    static void Main()
    {
        int canal;
        int pessoas;
        int totalPessoas = 0;

        
        int[] audiencia = new int[5]; 

        Console.WriteLine("Digite o número do canal (0 para encerrar) e o número de pessoas assistindo:");

        while (true)
        {
            Console.Write("Canal: ");
            canal = int.Parse(Console.ReadLine());

            if (canal == 0)
                break; 
                
            if (canal < 1 || canal > 4)
            {
                Console.WriteLine("Canal inválido! Digite entre 1 e 4.");
                continue;
            }

            Console.Write("Número de pessoas: ");
            pessoas = int.Parse(Console.ReadLine());

            audiencia[canal] += pessoas;
            totalPessoas += pessoas;
        }

        Console.WriteLine("\nPercentual de audiência por canal:");

        for (int i = 1; i <= 4; i++)
        {
            double percentual = 0;
            if (totalPessoas > 0)
                percentual = (audiencia[i] * 100.0) / totalPessoas;

            Console.WriteLine($"Canal {i}: {percentual:F2}%");
        }
    }
}
