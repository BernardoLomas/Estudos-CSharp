using System;

class Retangulo
{
    public double largura { get; set; }
    public double altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        this.largura = largura;
        this.altura = altura;
    }

    public double CalcularArea()
    {
        return largura * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }

    public override string ToString()
    {
        return $"Largura: {largura}\nAltura: {altura}\nÁrea: {CalcularArea()}\nPerímetro: {CalcularPerimetro()}";
    }
}

class Program
{
    static void Main()
    {
        Retangulo retangulo1 = new Retangulo(2, 2);
        Console.WriteLine(retangulo1.ToString());
    }
}
