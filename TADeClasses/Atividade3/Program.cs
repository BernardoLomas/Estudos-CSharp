using System;

class DataNascimento
{
    public int Dia { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }

    public DataNascimento(int dia, int mes, int ano)
    {
        Dia = dia;
        Mes = mes;
        Ano = ano;
    }

    public override string ToString()
    {
        return $"{Dia:D2}/{Mes:D2}/{Ano}";
    }
}

class Aluno
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public DataNascimento Nascimento { get; set; }
    public string Telefone { get; set; }

    public Aluno(string nome, string email, DataNascimento nascimento, string telefone)
    {
        Nome = nome;
        Email = email;
        Nascimento = nascimento;
        Telefone = telefone;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\nEmail: {Email}\nData de Nascimento: {Nascimento}\nTelefone: {Telefone}\n";
    }
}

class Program
{
    static void Main()
    {
        Aluno[] alunos = new Aluno[50];
        int quantidade = 5; 

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome do aluno {i + 1}: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Escreva o email do aluno {i + 1}: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Escreva o dia de nascimento do aluno {i + 1}: ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine($"Escreva o mês de nascimento do aluno {i + 1}: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine($"Escreva o ano de nascimento do aluno {i + 1}: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine($"Escreva o telefone do aluno {i + 1}: ");
            string telefone = Console.ReadLine();

            DataNascimento data = new DataNascimento(dia, mes, ano);
            alunos[i] = new Aluno(nome, email, data, telefone);
        }

        Console.WriteLine("\n=== LISTA DE ALUNOS CADASTRADOS ===");
        ListarAlunos(quantidade, alunos);
    }

    static void ListarAlunos(int quantidade, Aluno[] alunos)
    {
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\nAluno {i + 1}:");
            Console.WriteLine(alunos[i]);
        }
    }
}
