class Alunos
{
    public string Nome { get; set; }
    public double Nota { get; set; }
    public Alunos Proximo { get; set; }
    public Alunos Anterior { get; set; }

    public Alunos(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
        Proximo = null;
        Anterior = null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantidade de alunos: ");
        int quantidade = int.Parse(Console.ReadLine());

        Alunos Primeiro = null;
        Alunos Ultimo = null;

        double SomaNotas = 0;

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome do aluno {i + 1}:");
            string nome = Console.ReadLine();

            Console.WriteLine($"Escreva a nota do aluno {i + 1}:");
            double nota = double.Parse(Console.ReadLine());

            Alunos novo = new Alunos(nome, nota);

            if (Primeiro == null)
            {
                Primeiro = novo;
                Ultimo = novo;
            }

            else
            {
                Ultimo.Proximo = novo;
                novo.Anterior = Ultimo;
                Ultimo = novo;
            }
        }

        Alunos Atual = Primeiro;

        while(Atual != null)
        {
            Console.WriteLine($"Nota do aluno {Atual.Nome}: {Atual.Nota}");
            SomaNotas += Atual.Nota;
            Atual = Atual.Proximo;
        }

        Alunos Agora = Ultimo;

        while(Agora != null)
        {
            Console.WriteLine($"Nome do aluno: {Agora.Nome}");
            Agora = Agora.Anterior;
        }

        Console.WriteLine($"Soma das notas: {SomaNotas}");

    }
}