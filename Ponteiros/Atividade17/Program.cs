class Tarefas
{
    public string Titulo { get; set; }
    public int Prioridade { get; set;}
    public Tarefas Proximo { get; set;}

    public Tarefas(string titulo, int prioridade)
    {
        Titulo = titulo;
        Prioridade = prioridade;
        Proximo = null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantas tarefas deseja inserir?");
        int quantidade = int.Parse(Console.ReadLine());

        Tarefas Primeiro = null;
        Tarefas Ultimo = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome da tarefa: ");
            string titulo = Console.ReadLine();

            Console.WriteLine($"Escreva a prioridade da tarefa: ");
            int prioridade = int.Parse(Console.ReadLine());

            Tarefas nova = new Tarefas(titulo, prioridade);

            if(Primeiro == null)
            {
                Primeiro = nova;
                Ultimo = nova;
            }
            else
            {
                Ultimo.Proximo = nova;
                Ultimo = nova;
            }
        }

        Tarefas Atual = Primeiro;
        while(Atual != null)
        {
            Console.WriteLine($"Nome da tarefa: {Atual.Titulo} | Prioridade: {Atual.Prioridade}");
            Atual = Atual.Proximo;
        }
    }
}