public class Produto
{
    public string NomeProduto { get; set; }
    public double PrecoCompra { get; set; }
    public double PrecoVenda { get; set; }
    public string Fabricante { get; set; }
    public string DataAquisicao { get; set; }

    public Produto(string nome, double compra, double venda, string fabricante, string data)
    {
        NomeProduto = nome;
        PrecoCompra = compra;
        PrecoVenda = venda;
        Fabricante = fabricante;
        DataAquisicao = data;
    }

}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[2];

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Preço de compra do produto: ");
            double compra = double.Parse(Console.ReadLine());

            Console.WriteLine($"Preço de venda do produto: ");
            double venda = double.Parse(Console.ReadLine());

            Console.WriteLine($"Fabricante do produto: ");
            string fabricante = Console.ReadLine();

            Console.WriteLine($"Data de aquisição: ");
            string data = Console.ReadLine();

            produtos[i] = new Produto(nome, compra, venda, fabricante, data);
        }

        for (int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i].PrecoCompra > produtos[i].PrecoCompra * 1.5)
            {
                Console.WriteLine($"Esse produto {produtos[i].NomeProduto}, tem o preço de venda R${produtos[i].PrecoVenda}, pelo menos 50% maior do que o preço de compra: R${produtos[i].PrecoCompra}");
            }
        }


    }
}