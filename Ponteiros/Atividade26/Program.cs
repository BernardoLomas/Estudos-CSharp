class Musica
{
    public string Titulo {get; set;}
    public string Artista {get; set;}
    public double Duração {get; set;}
    public Musica Proximo {get; set;}

    public Musica(string titulo, string artista, double duracao)
    {
        Titulo = titulo;
        Artista = artista;
        Duração = duracao;
        Proximo = null;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantas faixas deseja tocar na playlist? ");
        int quantidade = int.Parse(Console.ReadLine());

        Musica Primeiro = null;
        Musica Ultimo = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Nome da faixa: ");
            string titulo = Console.ReadLine();
            Console.WriteLine($"Artista: ");
            string artista = Console.ReadLine();
            Console.WriteLine($"Duração da faixa:  ");
            double duracao = double.Parse(Console.ReadLine());

            Musica novo = new Musica(titulo, artista, duracao);

            if(Ultimo == null)
            {
                Ultimo = novo;
                Ultimo.Proximo = Ultimo;
            }
            else
            {
                novo.Proximo = Ultimo.Proximo;
                Ultimo.Proximo = novo;
                Ultimo = novo;
            }
        }

        Musica Atual = Ultimo;
        int cont = 0;

        do
        {
            Console.WriteLine($"Nome da música: {Atual.Titulo} | Artista: {Atual.Artista} | Duração: {Atual.Duração}");
            Atual = Ultimo.Proximo;
            cont++;

        } while(cont < 11);
    }
}