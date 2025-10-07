class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("Valor de n: ");
        n = int.Parse(Console.ReadLine());

        ContagemRegressiva(n - 1); 
    }

    static int ContagemRegressiva(int n)
    {
        if (n < 0)
            return 0;

        Console.WriteLine(n);
        return ContagemRegressiva(n - 1);
    }
}