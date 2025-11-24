class Program
{
    static void Main()
    {
        Stack<string> Lidos = new Stack<string>();
        Stack<string> QueroLer = new Stack<string>();

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"<== LIVROS JÁ LIDOS ==>");
            Console.WriteLine($"Livro {i + 1}: ");
            string Valor = Console.ReadLine();
            Lidos.Push(Valor);
        }

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"<== LIVROS QUE QUERO LER ==>");
            Console.WriteLine($"Livro {i + 1}: ");
            string Valor = Console.ReadLine();
            QueroLer.Push(Valor);
        }

        Stack<string> Repetidos = new Stack<string>();

        foreach(var l in Lidos)
        {
            if(QueroLer.Contains(l))
            {
                Repetidos.Push(l);
            }
        }

        Console.WriteLine($"Repetidos: ");

        foreach(var l in Repetidos)
        {
            Console.Write($"{l}");
        }
    }
}