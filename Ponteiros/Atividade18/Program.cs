class Produtos
{
    public string Nome { get; set; }
    public double Preco { get; set;}
    public Produtos Proximo { get; set;}

    public Produtos(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
        Proximo = null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantos produtos deseja inserir? ");
        int quantidade = int.Parse(Console.ReadLine());
        
        Produtos Primeiro = null;
        Produtos Ultimo = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Produtos novo = new Produtos(nome, preco);

            if (Primeiro == null)
            {
                Primeiro = novo;
                Ultimo = novo;
            }
            else
            {
                // Caso 2: Inserir no começo (preço > 100)
                if (preco > 100)
                {
                    novo.Proximo = Primeiro;
                    Primeiro = novo;
                }
                else // Caso 3: Inserir no final (preço <= 100)
                {
                    Ultimo.Proximo = novo;
                    Ultimo = novo;
                }
            }
        }

        Produtos Atual = Primeiro;
        while(Atual != null)
        {
            Console.WriteLine($"Nome do produto: {Atual.Nome} | Preço do produto: {Atual.Preco}");
            Atual = Atual.Proximo;
        }
    }
}