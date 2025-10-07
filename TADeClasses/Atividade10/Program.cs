class Program
{
    static void Main()
    {
        Console.WriteLine($"Escreva o valor de n: ");
        int n = int.Parse(Console.ReadLine());

        int soma = SomaDigitos(n);
        Console.WriteLine($"A soma dos dígitos de {n} é igual a {soma}");
    }

    static int SomaDigitos(int n)
    {
        if (n == 0)
            return 0;

        return (n % 10) + SomaDigitos(n / 10);
    }

}