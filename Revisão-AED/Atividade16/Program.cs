class Retangulo
{
    public double largura { get; set; }
    public double altura { get; set; }

    public Retangulo(double larguraDoRetangulo, double alturaDoRetangulo)
    {
        largura = larguraDoRetangulo;
        altura = alturaDoRetangulo;
    }

    public double CalcularArea()
    {
        return largura * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }

}

class Program
{
    public static void Main()
    {
        Retangulo retangulo1 = new Retangulo(10, 10);
        Console.WriteLine(retangulo1.CalcularArea());
        Console.WriteLine(retangulo1.CalcularPerimetro());
    }
}