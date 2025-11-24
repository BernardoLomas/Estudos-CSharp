class Cliente
{
    public string Nome {get; set;}
    public int Docs {get; set;}
    public int Time {get; set;}

    public Cliente(string nome, int docs, int time)
    {
        Nome = nome;
        Docs = docs;
        Time = time;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantidade de clientes na fila: ");
        int quantidade = int.Parse(Console.ReadLine());

        Queue<Cliente> Clientes = new Queue<Cliente>();

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Nome do cliente {i + 1}: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Quantidade de documentos: ");
            int docs = int.Parse(Console.ReadLine());

            int time = docs * 3;

            Clientes.Enqueue(new Cliente(nome, docs, time));
        }

        int TimeAcumulado = 0;

        foreach(var c in Clientes)
        {
            Console.WriteLine($"Cliente atendido: {c.Nome} | Documentos: {c.Docs} | Tempo: {c.Time} min.");
            Console.WriteLine($"Tempo total acumulado: {TimeAcumulado += c.Time} min.");
        }

    }
}