class Program
{
    private static void Main(string[] args)
    {
        int n;
        Console.WriteLine($"Escreva o valor de n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 2)
            Console.WriteLine($"Erro! Escreva um valor positivo: ");

        int[] A = Fibonacci(n);
        Console.WriteLine("Sequência de Fibonacci: ");
        MostraFibonacci(A);

    }

    static int[] Fibonacci(int n)
    {
        int[] sequencia = new int[n];
        sequencia[0] = 1;
        sequencia[1] = 1;

        for (int i = 2; i < n; i++)
        {
            sequencia[i] = sequencia[i - 1] + sequencia[i - 2];
        }

        return sequencia;
    }

    static void MostraFibonacci(int[] sequencia)
    {
        for (int i = 0; i < sequencia.Length; i++)
        {
            Console.Write($"{sequencia[i]} - ");
        }
    }
}