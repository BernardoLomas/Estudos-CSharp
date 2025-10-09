class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine($"Você quer descobrir o fatorial de qual número? ");
        n = int.Parse(Console.ReadLine());

        int resultado = Fatorial(n);
        Console.WriteLine($"O fatorial de {n} é igual a {resultado}");
    }

    static int Fatorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n  * Fatorial(n - 1);
    }
}