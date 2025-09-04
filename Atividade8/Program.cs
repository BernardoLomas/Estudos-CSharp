class Program
{
    private static void Main(string[] args)
    {
        string n;
        do
        {
            Console.WriteLine("Escreva um número inteiro com 4 algarismos: ");
            n = Console.ReadLine();

        } while (n == null || n.Length != 4);

        var A = Palindromos(n);
        if (A == true) Console.Write($"{n} é um palíndromo.");
        else Console.WriteLine($"{n} não é um palíndromo.");

    }

    static bool Palindromos(string n)
    {
        string contrario = n;


        for (int i = 0; i < n.Length / 2; i++)
        {
            if (n[i] != n[n.Length - 1 - i])
                return false;
        }
        return true;
    }
}