using System;

class Filmes
{
    public string Nome { get; set; }
    public double Duracao { get; set; }
    public string Diretor { get; set; }
    public string Categoria { get; set; }
    public string Info { get; set; }

    public Filmes(string nome, double duracao, string diretor, string categoria, string info)
    {
        Nome = nome;
        Duracao = duracao;
        Diretor = diretor;
        Categoria = categoria;
        Info = info;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\nDuração: {Duracao} horas\nDiretor: {Diretor}\nCategoria: {Categoria}\nInfo: {Info}";
    }
}

class Program
{
    static void Main()
    {
        Filmes[] filmes = new Filmes[5]; 

        for (int i = 0; i < filmes.Length; i++)
        {
            Console.WriteLine($"\n--- FILME {i + 1} ---");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Duração (em horas): ");
            double duracao = double.Parse(Console.ReadLine());

            Console.Write("Diretor: ");
            string diretor = Console.ReadLine();

            Console.WriteLine("Escolha a categoria:");
            Console.WriteLine("1 - Ação");
            Console.WriteLine("2 - Suspense");
            Console.WriteLine("3 - Terror");
            Console.WriteLine("4 - Romance");

            int opcaoCategoria = int.Parse(Console.ReadLine());
            string categoria = "";

            switch (opcaoCategoria)
            {
                case 1:
                    categoria = "Ação";
                    break;
                case 2:
                    categoria = "Suspense";
                    break;
                case 3:
                    categoria = "Terror";
                    break;
                case 4:
                    categoria = "Romance";
                    break;
                default:
                    categoria = "Inválida";
                    break;
            }

            Console.Write("Informações extras: ");
            string info = Console.ReadLine();

            filmes[i] = new Filmes(nome, duracao, diretor, categoria, info);
        }

        Console.WriteLine("\n=== LISTA DE FILMES ===");
        ListarFilmes(filmes);

        Console.Write("\nDeseja listar filmes por categoria? (S/N): ");
        string resposta = Console.ReadLine().ToUpper();

        if (resposta == "S")
        {
            Console.WriteLine("\nEscolha a categoria:");
            Console.WriteLine("1 - Ação");
            Console.WriteLine("2 - Suspense");
            Console.WriteLine("3 - Terror");
            Console.WriteLine("4 - Romance");

            int opcao = int.Parse(Console.ReadLine());
            string categoriaEscolhida = "";

            switch (opcao)
            {
                case 1:
                    categoriaEscolhida = "Ação";
                    break;
                case 2:
                    categoriaEscolhida = "Suspense";
                    break;
                case 3:
                    categoriaEscolhida = "Terror";
                    break;
                case 4:
                    categoriaEscolhida = "Romance";
                    break;
                default:
                    categoriaEscolhida = "Inválida";
                    break;
            }

            Console.WriteLine($"\n=== FILMES DA CATEGORIA: {categoriaEscolhida} ===");
            ListarFilmesPorCategoria(filmes, categoriaEscolhida);
        }
    }

    static void ListarFilmes(Filmes[] filmes)
    {
        for (int i = 0; i < filmes.Length; i++)
        {
            Console.WriteLine($"\nFilme {i + 1}:");
            Console.WriteLine(filmes[i]);
        }
    }

    // Mostra apenas filmes de uma categoria específica
    static void ListarFilmesPorCategoria(Filmes[] filmes, string categoria)
    {
        bool encontrou = false; // verifica se achou algum filme

        for (int i = 0; i < filmes.Length; i++)
        {
            if (filmes[i].Categoria == categoria)
            {
                Console.WriteLine($"\nFilme {i + 1}:");
                Console.WriteLine(filmes[i]);
                encontrou = true;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("Nenhum filme encontrado nessa categoria.");
        }
    }
}
