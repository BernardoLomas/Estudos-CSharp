class Objeto
{
    public string Nome { get; set; }
    public Objeto Proximo { get; set; }
    public Objeto Anterior { get; set; }

    public Objeto(string nome)
    {
        Nome = nome;
        Proximo = null;
    }
}
class Program
{
    public static void Main()
    {
        Console.WriteLine($"Quantidade de nomes: ");
        int quantidade = int.Parse(Console.ReadLine());

        Objeto Primeiro = null;
        Objeto Ultimo = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Nome {i+1}: ");
            string nome = Console.ReadLine();
            Objeto novo = new Objeto(nome);

            if(Primeiro == null)
            {
                Primeiro = novo;
                Ultimo = novo;
            }
            else
            {
                Ultimo.Proximo = novo;
                Ultimo = novo;
            }
        }

        Objeto Atual = Primeiro;

        while(Atual != null)
        {
            Console.WriteLine($"Nome - {Atual.Nome}");
            Atual = Atual.Proximo;
        }
    }
}