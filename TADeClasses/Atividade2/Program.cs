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

    static void Main()
    {
        DataNascimento data1 = new DataNascimento(25, 01, 2007);
        Aluno aluno1 = new Aluno("Bernardo Lomas", "bernardo.lomasb@gmail.com", data1, "3199999999");
        Console.WriteLine(aluno1);
    }
}