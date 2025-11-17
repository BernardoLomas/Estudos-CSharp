class Program
{
    static void Main()
    {
        Stack<int> PilhaA = new Stack<int>();
        Stack<int> PilhaB = new Stack<int>();
        Queue<int> FilaComum = new Queue<int>();

        for (int i = 0; i <= 4; i++) 
        {
            Console.WriteLine("Escreva um valor para armazenar na pilha A:");
            int Valor = int.Parse(Console.ReadLine());
            PilhaA.Push(Valor);
        }

        for (int i = 0; i <= 4; i++) 
        {
            Console.WriteLine("Escreva um valor para armazenar na pilha B:");
            int Valor = int.Parse(Console.ReadLine());
            PilhaB.Push(Valor);
        }

        while (PilhaA.Count > 0)
        {
            int Elemento = PilhaA.Pop();

            if (PilhaB.Contains(Elemento))
            {
                FilaComum.Enqueue(Elemento);
            }
        }

        Console.WriteLine("Elementos em comum entre as pilhas: ");
        foreach (var repetidos in FilaComum)
        {
            Console.WriteLine(repetidos);
        }
    }
}
