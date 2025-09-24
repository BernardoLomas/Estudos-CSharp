class Program
{
    private static void Main(string[] args)
    {
        int n;
        Console.Write($"Escreva o valor de n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            Console.Write($"Valor inválido! Digite um valor positivo: ");

        double resultado1 = Sequencia1(n);
        MostraResultado1(resultado1);

        int resultado2 = Sequencia2(n);
        MostraResultado2(resultado2);

    }

    static double Sequencia1(int n)
    {
        double i, resultado = 0;

        for (i = 1; i <= n - 1; i++)
        {
            resultado += (double)i / (i + 1);
        }

        return resultado;
    }

    static void MostraResultado1(double resultado)
    {
        Console.WriteLine($"O resultado da primeira sequência é: {resultado}.");
    }

    static int Sequencia2(int n)
    {
        int resultado = 100;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
                resultado -= i;
            else
                resultado += i;
        }

        return resultado;
    }

    static void MostraResultado2(int resultado)
    {
        Console.WriteLine($"O resultado da segunda sequência é: {resultado}.");
    }

}