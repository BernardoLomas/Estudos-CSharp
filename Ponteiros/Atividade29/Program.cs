class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantidade de nomes para serem lidos: ");
        int quantidade = int.Parse(Console.ReadLine());

        Stack<string> PilhaNomes = new Stack<string>();

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome {i + 1}: ");
            string nome = Console.ReadLine();
            PilhaNomes.Push(nome);
        }


        for (int j = PilhaNomes.Count; j > 0; j--)
        {
            if (j > 1)
            {
                PilhaNomes.Pop();
            }
            else
                Console.WriteLine($"Último nome da lista: {PilhaNomes.Peek()}");
        }
    }
}