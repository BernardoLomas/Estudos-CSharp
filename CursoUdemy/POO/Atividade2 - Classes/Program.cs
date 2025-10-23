/*🧩 Exercício 2 — Encapsulamento com propriedades

Altere a classe Pessoa:

Deixe os atributos Nome e Idade privados.

Crie propriedades (public string Nome { get; set; } e public int Idade { get; set; }).

Na Main, instancie e acesse os dados via propriedades.

👉 Objetivo: praticar modificadores de acesso e propriedades automáticas.
*/

class Pessoa
{
    //Atributos privados
    private string nome;
    private int idade;

    // Propriedades públicas
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

}

class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();

        p1.Nome = "Bernardo Lomas";
        p1.Idade = 18;

        Console.WriteLine($"Nome: {p1.Nome}, idade: {p1.Idade}");
    }
}