using System;
using System.Collections.Generic;

class Cidade
{
    public string Nome { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public Cidade(string nome, double lat, double lon)
    {
        Nome = nome;
        Latitude = lat;
        Longitude = lon;
    }

}

class Program
{
    static void Main()
    {
        Queue<Cidade> Roteiro = new Queue<Cidade>();
        Console.WriteLine("Quantas cidades possui o roteiro? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nome da cidade {i + 1}: ");
            string nome = Console.ReadLine();
            Console.Write($"Latitude da cidade {i + 1}: ");
            double lat = double.Parse(Console.ReadLine());
            Console.Write($"Longitude da cidade {i + 1}: ");
            double lon = double.Parse(Console.ReadLine());

            Roteiro.Enqueue(new Cidade(nome, lat, lon));
        }

        double Distancia = 0;
        Cidade Anterior = null;

        while (Roteiro.Count > 0)
        {
            Cidade Atual = Roteiro.Dequeue();

            if (Anterior != null)
            {
                double Dx = Atual.Latitude - Anterior.Latitude;
                double Dy = Atual.Longitude - Anterior.Longitude;
                double D = Math.Sqrt(Dx * Dx + Dy * Dy);
                Distancia += D;

                Console.WriteLine($"Distância de {Anterior.Nome} para {Atual.Nome} é igual a {D:F2}.");
            }

            Anterior = Atual;
        }

        Console.WriteLine($"\n A distância total do roteiro é: {Distancia:F2}!");
    }
}