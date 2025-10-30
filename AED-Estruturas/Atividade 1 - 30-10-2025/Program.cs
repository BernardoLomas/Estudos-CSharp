using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        SortedList Lista = new SortedList();
        Lista.Add(123, "Bernardo");
        Lista.Add(456, "Gustavo");
        Lista.Add(789, "Matheus");

        Console.WriteLine("Chave\nValor");

        foreach (DictionaryEntry Elemento in Lista)
        {
            int Chave = (int)Elemento.Key;
            string Valor = (string)Elemento.Value;

            Console.WriteLine($"{Chave} - {Valor}");
        }

        Console.ReadKey();
        Console.Clear();

        SortedList<string, string> APPLista = new SortedList<string, string>();

        APPLista.Add("txt", "Counter-Strike 2");
        APPLista.Add("dwg", "Rocket League");
        APPLista.Add("bcg", "Fortnite");

        foreach (KeyValuePair<string, string> ChaveValor in APPLista)
        {
            Console.WriteLine($"{ChaveValor.Key} - {ChaveValor.Value}");
        }

    }
}