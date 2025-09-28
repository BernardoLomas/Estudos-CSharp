class Program
{
    public static void Main()
    {
        double x, y;

        Console.WriteLine($"Escreva o valor de X: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine($"Escreva o valor de Y: ");
        y = double.Parse(Console.ReadLine());

        double potencia = Potencias(x, y);

        Console.WriteLine($"{x} elevado a {y} é igual a: {potencia}");

    }

    static double Potencias(double x, double y)
    {
        if (y == 0)
            return 1;
            
        return x * Potencias(x, y - 1);
    }
}