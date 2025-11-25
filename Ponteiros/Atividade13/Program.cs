class Cliente
{
    public string Nome { get; set; }
    public int Prioridade { get; set; }

    public Cliente(string nome, int prioridade)
    {
        Nome = nome;
        Prioridade = prioridade;
    }
}

class Program
{
    static void Main()
    {
        Queue<Cliente> Prio1 = new Queue<Cliente>();
        Queue<Cliente> Prio2 = new Queue<Cliente>();
        Queue<Cliente> Prio3 = new Queue<Cliente>();

        Console.WriteLine($"Escreva quantos clientes estão na fila: ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Nome do cliente {i + 1}: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Prioridade do cliente: ");
            int prioridade = int.Parse(Console.ReadLine());

            if (prioridade == 1)
            {
                Prio1.Enqueue(new Cliente(nome, prioridade));
            }
            else if (prioridade == 2)
            {
                Prio2.Enqueue(new Cliente(nome, prioridade));
            }
            else
                Prio3.Enqueue(new Cliente(nome, prioridade));
        }

        Console.Clear();

        Console.WriteLine("ATENDIMENTO POR PRIORIDADE");

        Console.WriteLine("PRIORIDADE 1 - ALTA");
        while (Prio1.Count > 0)
        {
            Cliente c = Prio1.Dequeue();
            Console.WriteLine($"Cliente: {c.Nome}");
        }

        Console.WriteLine("PRIORIDADE 2 - MÉDIA");
        while (Prio2.Count > 0)
        {
            Cliente c = Prio2.Dequeue();
            Console.WriteLine($"Cliente: {c.Nome}");
        }

        Console.WriteLine("PRIORIDADE 3 - BAIXA");
        while (Prio3.Count > 0)
        {
            Cliente c = Prio3.Dequeue();
            Console.WriteLine($"Cliente: {c.Nome}");
        }

    }
}