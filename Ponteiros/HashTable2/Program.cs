using System.Collections;
class Program
{
    static void Main(string[] args)
    {

        HashTable TabelaHash = new HashTable();

        TabelaHash.Add("123", "Bernardo Lomas");
        TabelaHash.Add("456", "Lucas Gabriel");
        TabelaHash.Add("789", "João Amaral");
        TabelaHash.Add("987", "Matheus Henrique");

        Console.WriteLine($"Dados inseridos: ");
        foreach(DictionaryEntry Elemento in TabelaHash)
        {
            Console.WriteLine($"{Elemento.Key} - Nome: {Elemento.Value}");
        }

        Console.ReadKey();

        Console.WriteLine($"Chaves: ");
        foreach(string Chave in TabelaHash.Keys)
        {
            Console.WriteLine($"{Chave}");
        }

        Console.ReadKey();

        Console.WriteLine($"Valores: ");
        foreach(string Valor in TabelaHash.Values)
        {
            Console.WriteLine($"{Valor}");
        }

        Console.ReadKey();
    }
}