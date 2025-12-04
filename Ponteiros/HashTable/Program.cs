class Produto
{
    public int Codigo { get; set; }
    public string Descricao { get; set ;}
    public double Preco { get; set; }

    public void Mostra()
    {
        Console.WriteLine($"{this.Codigo} - {this.Descricao} - R$ {this.Preco}");
    }

    public void Lê()
    {
        Console.WriteLine($"Código do produto: ");
        this.Codigo = int.Parse(Console.ReadLine());
        Console.WriteLine($"Descrição: ");
        this.Descricao = Console.ReadLine();
        Console.WriteLine($"Preço: ");
        this.Preco = double.Parse(Console.ReadLine());
    }
}

class Program
{
    static void Main()
    {
        int pos;

        List<Produto>[] Cadastro = new List<Produto>[8];

        for(int i = 0; i < 8; i++)
        {
            Cadastro[i] = new List<Produto>();
        }

        Produto x;

        for(int i = 0; i < 5; i++)
        {
            x = new Produto();
            x.Lê();
            pos = x.Codigo % 8;

            Cadastro[pos].Add(x);
        }

        Console.Clear();

        foreach(List<Produto> Lista in Cadastro)
        {
            if(Lista.Count != 0)
            {
                Console.WriteLine();
                foreach(Produto p in Lista)
                {
                    p.Mostra();
                }
            }
        }

        int chave;

        Console.WriteLine($"Código a ser retirado: ");
        chave = int.Parse(Console.ReadLine());

        x = new Produto();

        foreach(List<Produto> Lista in Cadastro)
        {
            if(Lista.Count != 0)
            {
                foreach(Produto p in Lista)
                {
                    if(p.Codigo == chave)
                        x = p;
                }
                
                Lista.Remove(x);
            }
        }
        
        Console.WriteLine($"Produto retirado | Código: {x.Codigo} | Descrição: {x.Descricao} | Preço: {x.Preco}");
    }
}