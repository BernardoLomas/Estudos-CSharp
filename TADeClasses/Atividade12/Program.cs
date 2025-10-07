class Pessoa
{
    public string Nome { get; set; }
    public string Idade { get; set; }

    public Pessoa(string nome, string idade)
    {
        Nome = nome;
        Idade = idade;

    }
    public string Falar()
    {
        return $"Olá, meu nome é {Nome} e tenho {Idade} anos.";
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa("Bernardo","18");
        Console.WriteLine(pessoa1.Falar());
    }
}