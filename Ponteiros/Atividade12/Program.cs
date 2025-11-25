class Tarefas
{
    public string Nome { get; set; }
    public int Paginas { get; set; }

    public Tarefas(string nome, int paginas)
    {
        Nome = nome;
        Paginas = paginas;
    }
}

class Program
{
    static void Main()
    {
        Queue<Tarefas> Arquivos = new Queue<Tarefas>();

        Console.WriteLine($"Quantas tarefas existem? ");
        int quantidade = int.Parse(Console.ReadLine());

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome da tarefa: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Escreva quantas páginas tem na tarefa: ");
            int paginas = int.Parse(Console.ReadLine());

            Arquivos.Enqueue(new Tarefas(nome, paginas));
        }

        foreach(var a in Arquivos)
        {
            Console.WriteLine($"Você deseja remover a próxima impressão da lista? (1 para Sim/2 para Não)");
            int Decisão = int.Parse(Console.ReadLine());

            if (Decisão == 1)
            {
                Arquivos.Dequeue();
            }
            else
            {
                foreach(var b in Arquivos)
                {
                    Console.WriteLine($"Nome do arquivo: {b.Nome} | Quantidade de páginas: {b.Paginas}");
                }
            }
        }
    }
}