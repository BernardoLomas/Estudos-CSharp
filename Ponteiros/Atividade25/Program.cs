class Pessoa
{
    public string Nome { get; set; }
    public Pessoa Proximo { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
        Proximo = null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Escreva quantas pessoas deseja cadastrar: ");
        int quantidade = int.Parse(Console.ReadLine());

        Pessoa Ultimo = null;

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Nome: ");
            string nome = Console.ReadLine();

            Pessoa novo = new Pessoa(nome);

            if (Ultimo == null)
            {
                Ultimo = novo; //Ultimo recebe novo
                Ultimo.Proximo = Ultimo; // Ultimo.Proximo recebe ultimo, apontando para o primeiro que é ele mesmo
            }
            else
            {
                novo.Proximo = Ultimo.Proximo; // novo aponta para o primeiro
                Ultimo.Proximo = novo;         // último aponta para o novo
                Ultimo = novo;                 // atualiza o último
            }
        }

        Console.WriteLine($"Quantindade de voltas na lista: ");
        int x = int.Parse(Console.ReadLine());
        Pessoa atual = Ultimo.Proximo; // começa no primeiro

        for (int i = 0; i < x; i++)
        {
            atual = atual.Proximo;
        }
        
        Console.WriteLine($"Pessoa sorteada: {atual.Nome}");
    }
}