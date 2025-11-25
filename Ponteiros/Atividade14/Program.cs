using System;
using System.Collections.Generic;
class Navegador
{
    public string URL { get; set; }
    public string Titulo { get; set; }

    public Navegador(string url, string titulo)
    {
        URL = url;
        Titulo = titulo;
    }
}

class Program
{
    static void Main()
    {
        Stack<Navegador> back = new Stack<Navegador>();
        Navegador Atual = null;

        while (true)
        {
            Console.WriteLine($"\n === MENU === ");
            Console.WriteLine($"1 - Visitar nova página");
            Console.WriteLine($"2 - Voltar (POP)");
            Console.WriteLine($"3 - Mostrar página atual");
            Console.WriteLine($"4 - Histórico");
            Console.WriteLine($"0 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Console.Write($"URL: ");
                    string url = Console.ReadLine();
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();

                    if (Atual != null)
                        back.Push(Atual); //Push coloca um objeto no topo da pilha, nesse casso se a Página atual não for do tipo null, ela vai para o topo
                    
                    Atual = new Navegador(url, titulo);
                    Console.WriteLine($"Visitando: {Atual.Titulo} | URL: {Atual.URL}");
                    break;
                
                case "2":
                    if(back.Count == 0)
                    {
                        Console.WriteLine($"Não há páginas para voltar!");
                    }
                    else
                    {
                        Atual = back.Pop();
                        Console.WriteLine($"Voltando para: {Atual.Titulo}");
                    }
                    break;
                
                case "3":
                    if(Atual == null)
                    {
                        Console.WriteLine("Nenhuma página aberta!");
                    }
                    else
                        Console.WriteLine($"Página atual: {Atual.Titulo} | URL: {Atual.URL}");
                    break;
                
                case "4":
                    Console.WriteLine("=== HISTÓRICO ===");
                    foreach(Navegador p in back)
                        Console.WriteLine($"{p.Titulo} | URL: {p.URL}");
                    break;
                
                case "0":
                    return;

                default:
                    Console.WriteLine("Opção inválida!!");
                    break;
            }
        }
    }
}