class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine($"Escreva o valor de n: ");
        n = int.Parse(Console.ReadLine());

        int indice = 1;
        int soma = SomaN(n, indice);
        Console.WriteLine($"A soma de todos os elementos de 1 até {n} é igual a: {soma}");
    }

    static int SomaN(int n, int indice)
    {
        if (indice > n)
            return 0;
        
        return indice + SomaN(n, indice + 1);
    }
}