/* 🧩 Exercício 1 — Classe simples e instância 
Crie uma classe chamada Pessoa com os seguintes atributos públicos:

Nome (string)
Idade (int)

Na Main, crie um objeto dessa classe, atribua valores aos atributos e exiba no console:

 Saída esperada:
 Nome: Bernardo
 Idade: 18

👉 Objetivo: entender declaração de classe, atributos e instância.
*/

public class Pessoa
{
    private string Nome;
    private int Idade;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Listar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

class Program
{
    public static void Main()
    {
        Pessoa pessoa1 = new Pessoa("Bernardo Lomas", 18);
        pessoa1.Listar();
    }
}