class Aluno
{
    public string Nome { get; set; }
    public string Turma { get; set; }
    public string Disciplina { get; set; }
    public double Nota { get; set; }
    public Aluno Proximo { get; set; }
    public Aluno Anterior { get; set; }

    public Aluno(string nome, string turma, string disciplina, double nota)
    {
        Nome = nome;
        Turma = turma;
        Disciplina = disciplina;
        Nota = nota;
        Proximo = null;
        Anterior = null;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de alunos: ");
        int quantidade = int.Parse(Console.ReadLine());

        Aluno Primeiro = null;
        Aluno Ultimo = null;

        double SomaNotas = 0;

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Nome do aluno {i + 1}: ");
            string nome = Console.ReadLine();
            Console.Write("Turma: ");
            string turma = Console.ReadLine();
            Console.Write("Disciplina: ");
            string disciplina = Console.ReadLine();
            Console.Write("Nota: ");
            double nota = double.Parse(Console.ReadLine());

            SomaNotas += nota;

            Aluno novo = new Aluno(nome, turma, disciplina, nota);

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
        
        Console.WriteLine("\nLista na ordem normal:");
        Aluno Atual = Primeiro;

        Aluno Maior = Primeiro;
        Aluno Menor = Primeiro;

        while (Atual != null)
        {
            Console.WriteLine($"{Atual.Nome} | {Atual.Turma} | {Atual.Disciplina} | {Atual.Nota}");

            if (Atual.Nota > Maior.Nota)
                Maior = Atual;

            if (Atual.Nota < Menor.Nota)
                Menor = Atual;

            Atual = Atual.Proximo;
        }

        Console.WriteLine("\nLista ao contrário:");
        Aluno Agora = Ultimo;

        while (Agora != null)
        {
            Console.WriteLine($"{Agora.Nome} | {Agora.Turma} | {Agora.Disciplina} | {Agora.Nota}");
            Agora = Agora.Anterior;
        }

        Console.WriteLine("\nAluno do meio:");

        int meio = quantidade / 2;
        int contador = 0;
        Atual = Primeiro;

        while (Atual != null)
        {
            if (contador == meio)
            {
                Console.WriteLine($"{Atual.Nome} | {Atual.Turma} | {Atual.Disciplina} | {Atual.Nota}");
                break;
            }

            Atual = Atual.Proximo;
            contador++;
        }

        Console.WriteLine($"\nMédia da turma: {SomaNotas / quantidade:F2}");
        Console.WriteLine($"\nMaior nota: {Maior.Nome} ({Maior.Nota})");
        Console.WriteLine($"Menor nota: {Menor.Nome} ({Menor.Nota})");
    }
}
