using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> Inteiros = new List<int>();
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            int num = rand.Next(1, 21);
            Inteiros.Add(num);
        }

        Console.WriteLine("Lista completa: ");
        foreach (var num in Inteiros)
        {
            Console.Write(num + "  ");
        }

        Stack<int> Pilha = new Stack<int>();
        Stack<int> PilhaRepetidos = new Stack<int>();
        List<int> RepetidosNaLista = new List<int>();

        foreach (var num in Inteiros)
        {
            if (!RepetidosNaLista.Contains(num))
            {
                Pilha.Push(num);
                RepetidosNaLista.Add(num);
            }
            else
            {
                if (Pilha.Contains(num))
                {
                    Stack<int> Temp = new Stack<int>();
                    while (Pilha.Count > 0)
                    {
                        int Topo = Pilha.Pop();
                        if (Topo != num)
                            Temp.Push(Topo);
                    }
                    while (Temp.Count > 0)
                        Pilha.Push(Temp.Pop());
                }

                if (!PilhaRepetidos.Contains(num))
                    PilhaRepetidos.Push(num);
            }
        }

        Console.WriteLine("\nPilha sem os números repetidos: ");
        foreach (var p in Pilha)
            Console.Write(p + " ");

        Console.WriteLine("\nPilha de repetidos: ");
        foreach (var p in PilhaRepetidos)
            Console.Write(p + " ");
    }
}