using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Queue<string> Estacionamento = new Queue<string>();
        const int CapacidadeMaxima = 8;

        while (true)
        {
            Console.WriteLine("\n === MENU ESTACIONAMENTO ===");
            Console.WriteLine("1 - Estacionar veículo");
            Console.WriteLine("2 - Retirar veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");
            int Opcao = int.Parse(Console.ReadLine());

            if (Opcao == 0)
                break;

            switch(Opcao)
            {
                case 1:
                    Console.Write("Digite a placa do veículo: ");
                    string Placa = Console.ReadLine();

                    if (Estacionamento.Count < CapacidadeMaxima)
                    {
                        Estacionamento.Enqueue(Placa);
                        Console.WriteLine($"Veículo {Placa} estacionado.");
                    }
                    else
                    {
                        Console.WriteLine("Estacionamento cheio!!");
                    }
                    break;

                case 2:
                    Console.Write("Digite a placa que deseja retirar: ");
                    string PlacaRetirar = Console.ReadLine();

                    if (!Estacionamento.Contains(PlacaRetirar))
                    {
                        Console.Write("Veículo não encontrado no estacionamento!!");
                        break;
                    }

                    Queue<string> ListaAuxiliar = new Queue<string>();

                    while (Estacionamento.Peek() != PlacaRetirar)
                    {
                        ListaAuxiliar.Enqueue(Estacionamento.Dequeue());
                    }

                    Estacionamento.Dequeue();
                    Console.WriteLine($"Veículo {PlacaRetirar} retirado!!");

                    while (ListaAuxiliar.Count > 0)
                    {
                        Estacionamento.Enqueue(ListaAuxiliar.Dequeue());
                    }

                    break;

                case 3:
                    Console.WriteLine("\n === Veículos no estacionamento ===");
                    foreach (var v in Estacionamento)
                        Console.WriteLine(v);
                    break;

                default:
                    Console.WriteLine("Opção inválida!!");
                    break;
            }
        }
    }
}