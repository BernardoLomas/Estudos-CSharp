class PaginaWeb
{
    public string Nome { get; set; }
    public string URL { get; set; }

    public PaginaWeb(string nome, string url)
    {
        Nome = nome;
        URL = url;
    }
}
class Program
{
    static void Main()
    {
        Stack<PaginaWeb> PilhaPaginas = new Stack<PaginaWeb>();
        bool condicao = true;

        while (condicao)
        {
            Console.WriteLine($"\n === MENU ===");
            Console.WriteLine($"\n1 - Visitar página");
            Console.WriteLine($"\n2 - Voltar para página anterior");
            Console.WriteLine($"\n3 - Histórico");
            Console.WriteLine($"\n0 - Sair");

            string opcao = Console.ReadLine();
            int i = PilhaPaginas.Count;

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Escreva o nome da página nova: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine($"Escreva a URL da página: ");
                    string url = Console.ReadLine();

                    PilhaPaginas.Push(new PaginaWeb(nome, url));
                    break;

                case "2":
                    PilhaPaginas.Pop();
                    Console.WriteLine($"Página fechada!!");
                    var PaginaAux = PilhaPaginas.Peek();
                    Console.WriteLine($"Página anterior: {PaginaAux.Nome} | URL: {PaginaAux.URL}");
                    break;

                case "3":
                    while(i != 0)
                    {
                        var Aux = PilhaPaginas.Peek();
                        Console.WriteLine($"Página: {Aux.Nome} | URL: {Aux.URL}");
                        PilhaPaginas.Pop();
                        i--;
                    }
                    break;

                case "0":
                    condicao = false;
                    break;
            }
        }
    }
}