using System;

class Program
{
    private static void Main(string[] args)
    {
        string[] alunos = new string[50]; 

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Escreva o nome do aluno {i + 1}/{alunos.Length}: ");
            alunos[i] = Console.ReadLine();
        }

        var (media, notas) = MediaGeral(alunos);
        var (maior, menor, nomeMaior, nomeMenor) = MaiorEMenor(notas, alunos);

        Console.WriteLine($"\nA média de notas da turma é igual a: {media:F2}.");
        Console.WriteLine($"A maior nota da turma foi {maior}, do aluno {nomeMaior}.");
        Console.WriteLine($"A menor nota da turma foi {menor}, do aluno {nomeMenor}.");
    }

    static (double media, double[] notas) MediaGeral(string[] alunos)
    {
        Random X = new Random();
        double soma = 0;
        double[] notas = new double[alunos.Length];

        for (int i = 0; i < alunos.Length; i++)
        {
            notas[i] = X.Next(0, 11); 
            soma += notas[i];
        }

        double media = soma / alunos.Length;
        return (media, notas);
    }

    static (double maior, double menor, string nomeMaior, string nomeMenor) MaiorEMenor(double[] notas, string[] alunos)
    {
        double maior = double.MinValue, menor = double.MaxValue;
        string nomeMaior = "", nomeMenor = "";

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > maior)
            {
                maior = notas[i];
                nomeMaior = alunos[i];
            }

            if (notas[i] < menor)
            {
                menor = notas[i];
                nomeMenor = alunos[i];
            }
        }

        return (maior, menor, nomeMaior, nomeMenor);
    }
}
