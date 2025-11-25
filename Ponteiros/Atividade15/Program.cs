class Program
{
    static void Main()
    {
        Console.Write($"Digite a expressão: ");
        string exp = Console.ReadLine();

        Stack<char> pilha = new Stack<char>();

        foreach(char c in exp)
        {
            if(c == '(')
                pilha.Push(c); //O programa percorre cada char na expressão, se c for igual a (, ele da push e coloca no topo da lista, indicando que um parentese foi aberto
            
            if(c == ')') //Se ele achar um ), ele percebe que um parentese foi fechado.
            {
                if(pilha.Count == 0)// Aqui entra a lógica, se estamos no char de fechamento de parentese, mas a pilha não registrou nenhum parentese de abertura, ou seja, pilha.count == 0, quer dizer que um parentese foi fechado sem necessidade
                {
                    Console.WriteLine($"ERRO - Fecharam mais parênteses do que abriram!");
                    return;
                }
                pilha.Pop(); // Ao contrário, se pilha.count != 0, um parentese ja foi aberto, assim usamos o pop para excluir esse elemento no topo da lista, indicando que o parentese foi fechado e podemos seguir na expressão
            }
        }

        if(pilha.Count == 0)
            Console.WriteLine($"OK - parênteses válidos!");
        else
            Console.WriteLine("ERRO - existem parênteses não fechados!");
    }
}