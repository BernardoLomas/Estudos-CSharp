class Cliente
{
    public string Nome { get; set; }
    public int Produtos { get; set; }

    public Cliente(string nome, int produtos)
    {
        Nome = nome;
        Produtos = produtos;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantos clientes tem na fila? ");
        int Quantidade = int.Parse(Console.ReadLine());


        Queue<Cliente> FilaDeClientes = new Queue<Cliente>();

        for (int i = 0; i < Quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome do cliente {i + 1}: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Escreva a quantidade de itens do cliente {i + 1}: ");
            int produtos = int.Parse(Console.ReadLine());

            Cliente novo = new Cliente(nome, produtos);
            FilaDeClientes.Enqueue(novo);
        }

        int produtosNaFila = 0;
        
        while (FilaDeClientes.Count > 0)
        {
            Cliente atendido = FilaDeClientes.Dequeue();
            Console.WriteLine($"ATENDIMENTO DO CLIENTE: {atendido.Nome}, PRODUTOS: {atendido.Produtos}");
            produtosNaFila += atendido.Produtos;
        }

        Console.WriteLine($"Quantidade total de produtos na fila: {produtosNaFila}");
    }
}