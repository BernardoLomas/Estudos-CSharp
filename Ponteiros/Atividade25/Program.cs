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

        Ultimo = null;

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

        Console.WriteLine("\nLista Circular:");

        if (Ultimo != null)
        {
            Pessoa atual = Ultimo.Proximo; // começa no primeiro
            do
            {
                Console.WriteLine(atual.Nome);
                atual = atual.Proximo;
            }
            while (atual != Ultimo.Proximo); // voltou para o início
        }
    }
}