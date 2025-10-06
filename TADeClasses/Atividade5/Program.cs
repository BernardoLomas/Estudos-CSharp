class Produto
{
    public string NomeDoProduto { get; set; }
    public int CodigoCategoria { get; set; }
    public double PrecoUnitario { get; set; }
    public double Quantidade { get; set; }

    public Produto(string nome, int codigoCategoria, double precoUnitario, int quantidade)
    {
        NomeDoProduto = nome;
        CodigoCategoria = codigoCategoria;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }
}

class Categoria
{
    public int Codigo { get; set; }
    public string Descricao { get; set; }

    public Categoria(int codigo, string descricao)
    {
        Codigo = codigo;
        Descricao = descricao;
    }
}

class Program
{
    static void Main()
    {
        Categoria[] categorias = new Categoria[3];
        Produto[] produtos = new Produto[3];

        Console.WriteLine("=== CADASTRO DE CATEGORIAS ===");
        IncluirCategorias(categorias);

        Console.WriteLine("\n=== CADASTRO DE PRODUTOS ===");
        IncluirProdutos(produtos);

        Console.WriteLine("\n=== RELATÓRIO DE PRODUTOS ===");
        MostrarRelatorio(produtos, categorias);

        Console.WriteLine("\n=== INVENTÁRIO DO ESTOQUE ===");
        MostrarInventario(produtos);
    }

    static void IncluirCategorias(Categoria[] categorias)
    {
        for (int i = 0; i < categorias.Length; i++)
        {
            Console.WriteLine($"Código da categoria {i + 1}:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Descrição da categoria {i + 1}:");
            string descricao = Console.ReadLine();

            categorias[i] = new Categoria(codigo, descricao);
        }
    }

    static void IncluirProdutos(Produto[] produtos)
    {
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Nome do produto {i + 1}:");
            string nome = Console.ReadLine();

            Console.Write("Código da Categoria: ");
            int codigoCategoria = int.Parse(Console.ReadLine());

            Console.Write("Preço Unitário: ");
            double precoUnitario = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            produtos[i] = new Produto(nome, codigoCategoria, precoUnitario, quantidade);
        }
    }

     static void MostrarRelatorio(Produto[] produtos, Categoria[] categorias)
    {
        for (int i = 0; i < produtos.Length; i++)
        {
            Produto p = produtos[i];

            string descricaoCat = "Categoria não encontrada";
            for (int j = 0; j < categorias.Length; j++)
            {
                if (p.CodigoCategoria == categorias[j].Codigo)
                {
                    descricaoCat = categorias[j].Descricao;
                    break;
                }
            }

            Console.WriteLine($"\nProduto: {p.NomeDoProduto}");
            Console.WriteLine($"Categoria: {descricaoCat}");
            Console.WriteLine($"Preço Unitário: R$ {p.PrecoUnitario:F2}");
            Console.WriteLine($"Quantidade: {p.Quantidade}");
        }
    }

    static void MostrarInventario(Produto[] produtos)
    {
        double total = 0;

        for (int i = 0; i < produtos.Length; i++)
        {
            total += produtos[i].PrecoUnitario * produtos[i].Quantidade;
        }

        Console.WriteLine($"\nValor total em estoque: R$ {total:F2}");
    }
}

