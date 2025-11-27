class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public Musica Proximo { get; set; }
    public Musica Anterior { get; set; }

    public Musica(string titulo, string artista)
    {
        Titulo = titulo;
        Artista = artista;
        Proximo = null;
        Anterior = null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantas músicas deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        Musica Primeiro = null;
        Musica Ultimo = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome da música: ");
            string titulo = Console.ReadLine();
            Console.WriteLine($"Escreva o nome do artista/banda: ");
            string artista = Console.ReadLine();

            Musica nova = new Musica(titulo, artista);

            if(Primeiro == null)
            {
                Primeiro = nova;
                Ultimo = nova;
            }
            else
            {
                Ultimo.Proximo = nova;
                nova.Anterior = Ultimo;
                Ultimo = nova;
            }   
        }

        //Mostrando do início ao fim
        Console.WriteLine($"Playlist do início ao fim: ");
        Musica Atual = Primeiro;
        while(Atual != null)
        {
            Console.WriteLine($"Nome da música: {Atual.Titulo} | Artista: {Atual.Artista}");
            Atual = Atual.Proximo;
        }

        //Mostrando do fim ao início
        Console.WriteLine($"Playlist do fim ao início: ");
        Musica Agora = Ultimo;
        while(Agora != null)
        {
            Console.WriteLine($"Nome da música: {Agora.Titulo} | Artista: {Agora.Artista}");
            Agora = Agora.Anterior;
        }

    }
}