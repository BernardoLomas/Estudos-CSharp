class Cidades
{
    public string Nome { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public Cidades Proximo { get; set; }

    public Cidades(string nome, double latitude, double longitude)
    {
        Nome = nome;
        Latitude = latitude;
        Longitude = longitude;
        Proximo = null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantas cidades deseja cadastrar?");
        int quantidade = int.Parse(Console.ReadLine());

        Cidades Primeiro = null;
        Cidades Ultimo = null;

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Nome da cidade:");
            string nome = Console.ReadLine();

            Console.WriteLine($"Latitude:");
            double lat = double.Parse(Console.ReadLine());

            Console.WriteLine($"Longitude:");
            double lon = double.Parse(Console.ReadLine());

            Cidades nova = new Cidades(nome, lat, lon);

            if (Primeiro == null)
            {
                Primeiro = nova;
                Ultimo = nova;
            }
            else
            {
                Ultimo.Proximo = nova;
                Ultimo = nova;
            }
        }

        
        Cidades Atual = Primeiro;

        Cidades CidadeMaiorLatitude = Primeiro;
        Cidades CidadeMenorLongitude = Primeiro;

        Cidades Anterior = null;
        double DistanciaTotal = 0;

        while (Atual != null)
        {
            // Comparar maior latitude
            if (Atual.Latitude > CidadeMaiorLatitude.Latitude)
                CidadeMaiorLatitude = Atual;

            // Comparar menor longitude
            if (Atual.Longitude < CidadeMenorLongitude.Longitude)
                CidadeMenorLongitude = Atual;

            // Distância entre cidades consecutivas
            if (Anterior != null)
            {
                double Dx = Atual.Latitude - Anterior.Latitude;
                double Dy = Atual.Longitude - Anterior.Longitude;
                double D = Math.Sqrt(Dx * Dx + Dy * Dy);
                DistanciaTotal += D;

                Console.WriteLine($"Distância de {Anterior.Nome} → {Atual.Nome}: {D:F2} km");
            }

            Anterior = Atual;
            Atual = Atual.Proximo;
        }

        Console.WriteLine($"\nCidade com maior latitude:");
        Console.WriteLine($"{CidadeMaiorLatitude.Nome} | Lat: {CidadeMaiorLatitude.Latitude}");

        Console.WriteLine($"\nCidade com menor longitude:");
        Console.WriteLine($"{CidadeMenorLongitude.Nome} | Lon: {CidadeMenorLongitude.Longitude}");

        Console.WriteLine($"\nDistância total percorrida: {DistanciaTotal:F2} km");
    }
}
