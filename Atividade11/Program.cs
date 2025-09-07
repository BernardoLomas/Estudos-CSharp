using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("<=== Escolha uma opção para calcular ===>");
        Console.WriteLine("1 - Área do quadrado");
        Console.WriteLine("2 - Área do retângulo");
        Console.WriteLine("3 - Área do trapézio");
        Console.WriteLine("4 - Área do círculo");

        int casos = int.Parse(Console.ReadLine());

        switch (casos)
        {
            case 1:
                Console.WriteLine("Cálculo da área do quadrado");
                var A = Quadrado();
                Console.WriteLine($"Área do quadrado: {A}");
                break;

            case 2:
                Console.WriteLine("Cálculo da área do retângulo");
                var B = Retangulo();
                Console.WriteLine($"Área do retângulo: {B}");
                break;

            case 3:
                Console.WriteLine("Cálculo da área do trapézio");
                var C = Trapezio();
                Console.WriteLine($"Área do trapézio: {C}");
                break;

            case 4:
                Console.WriteLine("Cálculo da área do círculo");
                var D = Circulo();
                Console.WriteLine($"Área do círculo: {D}");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    static double Quadrado()
    {
        Console.Write("Escreva o valor do lado do quadrado: ");
        double lado = double.Parse(Console.ReadLine());
        return lado * lado;
    }

    static double Retangulo()
    {
        Console.Write("Escreva o valor da altura do retângulo: ");
        double altura = double.Parse(Console.ReadLine());
        Console.Write("Escreva o valor da base do retângulo: ");
        double baseR = double.Parse(Console.ReadLine());

        return baseR * altura;
    }

    static double Trapezio()
    {
        Console.Write("Escreva o valor da base menor do trapézio: ");
        double baseMenor = double.Parse(Console.ReadLine());
        Console.Write("Escreva o valor da base maior do trapézio: ");
        double baseMaior = double.Parse(Console.ReadLine());
        Console.Write("Escreva o valor da altura do trapézio: ");
        double altura = double.Parse(Console.ReadLine());

        return (baseMaior + baseMenor) * altura / 2;
    }

    static double Circulo()
    {
        Console.Write("Escreva o valor do raio do círculo: ");
        double raio = double.Parse(Console.ReadLine());

        return Math.PI * Math.Pow(raio, 2);
    }
}
