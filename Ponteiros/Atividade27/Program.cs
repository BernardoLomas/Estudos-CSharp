class Onibus
{
    public string NomeDoPonto { get; set; }
    public double Distancia { get; set; }
    public Onibus Proximo { get; set; }

    public Onibus(string nomedoponto, double distancia)
    {
        NomeDoPonto = nomedoponto;
        Distancia = distancia;
        Proximo = null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Escreva quantos pontos tem a viagem: ");
        int quantidade = int.Parse(Console.ReadLine());

        Onibus Primeiro = null;
        Onibus Ultimo = null;

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Nome do ponto: ");
            string nomedoponto = Console.ReadLine();
            Console.WriteLine($"Distância até o próximo ponto: ");
            double distancia = double.Parse(Console.ReadLine());

            Onibus novo = new Onibus(nomedoponto, distancia);

            if (Ultimo == null)
            {
                Ultimo = novo;
                novo.Proximo = Ultimo;
            }
            else
            {
                novo.Proximo = Ultimo.Proximo;
                Ultimo.Proximo = novo;
                Ultimo = novo;
            }
        }

        Onibus Atual = Ultimo;
        double DTotal = 0;

        Console.WriteLine($"Quantas voltas o ônibus vai dar? ");
        int voltas = int.Parse(Console.ReadLine());
        int cont = 0;

        for (int i = 0; i < voltas; i++)
        {
            do
            {
                Console.WriteLine($"Nome do ponto: {Atual.Proximo.NomeDoPonto} | Distância para o próximo: {Atual.Proximo.Distancia}KMs | Distância total percorrida: {DTotal:F2} KMs");
                DTotal += Atual.Distancia;
                cont++;
                Atual = Atual.Proximo;

            } while (cont < quantidade);
            cont = 0;
            Console.WriteLine($"\n Volta {i + 1} completa!");
        }
    }
}