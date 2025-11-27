class Aluno
{
    public string Nome { get; set; }
    public double Nota { get; set; }
    public Aluno Proximo { get; set; }

    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
        Proximo = null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Escreva quantidade de alunos que deseja cadastrar: ");
        int quantidade = int.Parse(Console.ReadLine());

        Aluno Primeiro = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Escreva o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Escreva a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            Aluno novo = new Aluno(nome, nota);

            if(Primeiro == null)
            {
                Primeiro = novo;
            }
            else if(novo.Nota < Primeiro.Nota)
            {
                novo.Proximo = Primeiro;
                Primeiro = novo;
            }
            else
            {
                Aluno Atual = Primeiro;
                while(Atual.Proximo != null && Atual.Proximo.Nota < novo.Nota)
                {
                    Atual = Atual.Proximo;
                }

                novo.Proximo = Atual.Proximo;
                Atual.Proximo = novo;
            }
        }

        Aluno Aux = Primeiro;
        while(Aux != null)
        {
            Console.WriteLine($"Nome do aluno: {Aux.Nome} | Nota: {Aux.Nota}");
            Aux = Aux.Proximo;
        }
    }
}