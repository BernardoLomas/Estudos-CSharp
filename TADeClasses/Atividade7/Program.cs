class Program
{
    static void Main()
    {
        int fatorial;

        Console.WriteLine($"Escreva o valor fatorial a ser calculado: ");
        fatorial = int.Parse(Console.ReadLine());

        int Fcalc = Calculo(fatorial);
        Console.WriteLine($"O valor de {fatorial} fatorial é: {Fcalc}");
    }

    static int Calculo(int fatorial)
    {
        if (fatorial == 1)
            return 1;
        else
            return fatorial * Calculo(fatorial - 1);
    }
}