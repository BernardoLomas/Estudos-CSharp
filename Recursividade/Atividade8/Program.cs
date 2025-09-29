using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        int soma = SomaDivisores(n, n);

        Console.WriteLine($"A soma dos divisores de {n} é: {soma}");
    }

    static int SomaDivisores(int n, int divisor)
    {
        if (divisor == 0) 
            return 0;

        if (n % divisor == 0)
            return divisor + SomaDivisores(n, divisor - 1);
        else
            return SomaDivisores(n, divisor - 1);
    }
}
