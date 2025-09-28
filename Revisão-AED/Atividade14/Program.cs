using System;

class Program
{
    private static void Main(string[] args)
    {
        string[] produtos = new string[10];

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Escreva o nome do produto {i + 1}/{produtos.Length}:");
            produtos[i] = Console.ReadLine();
        }

        var (valor, quantidade) = PrecoEQuantidade(produtos);

        Console.WriteLine("\n<=== Inventário de Estoque ===>");
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Produto: {produtos[i]} | Quantidade: {quantidade[i]} | Valor total: R$ {valor[i]:F2}");
        }
    }

    static (double[] valor, int[] quantidade) PrecoEQuantidade(string[] produtos)
    {
        double[] precos = new double[produtos.Length];
        double[] valor = new double[produtos.Length];
        int[] quantidade = new int[produtos.Length];

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Escreva a quantidade de exemplares do produto {produtos[i]}:");
            quantidade[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Escreva o preço do produto {produtos[i]}:");
            precos[i] = double.Parse(Console.ReadLine());

            valor[i] = quantidade[i] * precos[i];
        }

        return (valor, quantidade);
    }
}
