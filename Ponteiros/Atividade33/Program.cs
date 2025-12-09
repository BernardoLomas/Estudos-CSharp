class Objeto
{
    public string Nome { get; set; }
    public Objeto Proximo { get; set ;}

    public Objeto(string nome)
    {
        Nome = nome;
        Proximo = null;
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine($"Digite a quantidade de objetos a serem inseridos na lista: ");
        int quantidade = int.Parse(Console.ReadLine());

        Objeto Primeiro = null;
        Objeto Ultimo = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Nome: ");
            string nome = Console.ReadLine();

            Objeto novo = new Objeto(nome);

            if(Primeiro == null)
            {
                Primeiro = novo;
                Ultimo = novo;
            }
            else
            {
                Ultimo.Proximo = novo;
                Ultimo = novo;
            }
        }

        Objeto Atual = Primeiro;
        while(Atual != null)
        {
            if(Atual == Primeiro)
            {
                Primeiro = Atual.Proximo;
                Atual = Atual.Proximo;
            }

            Console.WriteLine($"Nome: {Atual.Nome}");
            Atual = Atual.Proximo;
        }
    }
}