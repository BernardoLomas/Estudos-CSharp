using System;

class Program
{
    public static void Main()
    {
        string palavra = "bernardo";

        string invertida = InverteString(palavra, palavra.Length - 1);

        Console.WriteLine($"Original: {palavra}");
        Console.WriteLine($"Invertida: {invertida}");
    }

    static string InverteString(string palavra, int indice)
    {
        // Caso base: chegou no primeiro caractere
        if (indice == 0)
            return palavra[0].ToString();

        // Concatena o caractere atual com a chamada recursiva
        return palavra[indice] + InverteString(palavra, indice - 1);
    }
}
