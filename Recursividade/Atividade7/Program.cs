using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Escreva o número: ");
        string numero = Console.ReadLine();

        int indice = numero.Length - 1; 

        int quantidade = ContaDigitos(numero, indice);

        Console.WriteLine($"A quantidade de dígitos do número {numero} é: {quantidade}");
    }

    static int ContaDigitos(string numero, int indice)
    {
        if (indice < 0) 
            return 0;

        return 1 + ContaDigitos(numero, indice - 1); // soma 1 e chama recursivamente
    }
}
