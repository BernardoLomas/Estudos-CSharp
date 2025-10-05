using System;

class Aluno
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string DataNascimento { get; set; }
    public string Telefone { get; set; }

    public Aluno(string nome, string email, string dataNascimento, string telefone)
    {
        Nome = nome;
        Email = email;
        DataNascimento = dataNascimento;
        Telefone = telefone;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\nEmail: {Email}\nData de Nascimento: {DataNascimento}\nTelefone: {Telefone}\n";
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno1 = new Aluno("Bernardo Lomas", "bernardo.lomasb@gmail.com", "25/01/2007", "3199999999");
        Console.WriteLine(aluno1);
    }
}