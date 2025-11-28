class Palavra
{
    public string Nome { get; set; }
    public Palavra Proximo { get; set; }

    public Palavra(string nome)
    {
        Nome = nome;
        Proximo = null;
    }
}

class Program
{
    static void Main()
    {
        Palavra Primeiro = null;

        Console.Write("Quantos nomes deseja inserir? ");
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Palavra novo = new Palavra(nome);

            if (Primeiro == null)
            {
                Primeiro = novo;
                continue;
            }

            if (string.Compare(nome, Primeiro.Nome, StringComparison.OrdinalIgnoreCase) < 0)
            {
                novo.Proximo = Primeiro;
                Primeiro = novo;
                continue;
            }

            Palavra Atual = Primeiro;

            while (Atual.Proximo != null && string.Compare(Atual.Proximo.Nome, nome, StringComparison.OrdinalIgnoreCase) < 0)
            {
                Atual = Atual.Proximo;
            }

            // Inserção
            novo.Proximo = Atual.Proximo;
            Atual.Proximo = novo;
        }

        Console.WriteLine("\nLista de nomes ordenados:");
        Palavra aux = Primeiro;

        while (aux != null)
        {
            Console.WriteLine(aux.Nome);
            aux = aux.Proximo;
        }
    }
}
