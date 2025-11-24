class Clientes
{
    public string Nome { get; set; }
    public int Prioridade { get; set; }

    public Clientes(string nome, int prioridade)
    {
        Nome = nome;
        Prioridade = prioridade;
    }
}

class Program
{
    static void Main()
    {
        Queue<Clientes> Clientes1 = new Queue<Clientes>(); 
        Queue<Clientes> Clientes2 = new Queue<Clientes>(); 
        Queue<Clientes> Clientes3 = new Queue<Clientes>(); 

        Console.WriteLine($"Quantos clientes estão na fila? ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome do cliente {i + 1}: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Qual a prioridade desse cliente? (1=Alta / 2=Média / 3=Baixa)");
            int prioridade = int.Parse(Console.ReadLine());

            if (prioridade == 1)
                Clientes1.Enqueue(new Clientes(nome, prioridade));

            else if (prioridade == 2)
                Clientes2.Enqueue(new Clientes(nome, prioridade));

            else
                Clientes3.Enqueue(new Clientes(nome, prioridade));
        }

        Console.WriteLine($"\nATENDIMENTO — ALTA PRIORIDADE");
        while (Clientes1.Count > 0)
        {
            var c = Clientes1.Dequeue();
            Console.WriteLine($"Cliente {c.Nome} | Prioridade {c.Prioridade} | ATENDIDO");
        }

        Console.WriteLine($"\nATENDIMENTO — MÉDIA PRIORIDADE");
        while (Clientes2.Count > 0)
        {
            var c = Clientes2.Dequeue();
            Console.WriteLine($"Cliente {c.Nome} | Prioridade {c.Prioridade} | ATENDIDO");
        }

        Console.WriteLine($"\nATENDIMENTO — BAIXA PRIORIDADE");
        while (Clientes3.Count > 0)
        {
            var c = Clientes3.Dequeue();
            Console.WriteLine($"Cliente {c.Nome} | Prioridade {c.Prioridade} | ATENDIDO");
        }
    }
}
