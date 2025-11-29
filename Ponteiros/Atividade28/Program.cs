using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> Pilha = new Stack<int>();
        Console.Write("Escreva a quantidade de números que deseja colocar na pilha: ");
        int quantidade = int.Parse(Console.ReadLine());

        for(int i = 0; i < quantidade; i++)
        {
            Console.Write($"Termo {i + 1} da pilha: ");
            int termo = int.Parse(Console.ReadLine());
            Pilha.Push(termo);
        }
        
        while (Pilha.Count > 0)
        {
            int valorRetirado = Pilha.Pop();
            Console.WriteLine($"Elemento retirado: {valorRetirado}");
        }
        
        Console.WriteLine("\nA pilha foi esvaziada.");
    }
}