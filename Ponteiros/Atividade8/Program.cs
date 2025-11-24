class Tarefa
{
    public string Titulo { get; set; }
    public int Prioridade { get; set; }
    public Tarefa Proximo { get; set; }

    public Tarefa(string titulo, int prioridade)
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

        Console.WriteLine($"Escreva quantas tarefas deseja cadastrar e listar: ");
        int quantidade = int.Parse(Console.ReadLine());

        Tarefa Primeiro = null;
        Tarefa Ultimo = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Título da tarefa {i + 1}:");
            string titulo = Console.ReadLine();

            Console.WriteLine($"Prioridade da tarefa {i + 1}:");
            int prioridade = int.Parse(Console.ReadLine());

            Tarefa nova = new Tarefa(titulo, prioridade);

            if (Primeiro == null)
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

        Console.WriteLine("\n=== LISTA DE TAREFAS ===");
        Tarefa Atual = Primeiro;

        while (Atual != null)
        {
            Console.WriteLine($"Tarefa: {Atual.Titulo} | Prioridade: {Atual.Prioridade}");
            Atual = Atual.Proximo;
        }
    }
}