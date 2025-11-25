class Caixa
{
    public string Nome {get; set;}
    public double Peso {get; set;}

    public Caixa(string nome, double peso)
    {
        Nome = nome;
        Peso = peso;
    }
}

class Program
{
    static void Main()
    {
        Stack<Caixa> Caixas = new Stack<Caixa>();

        double PesoMax = 0.00;

        while(PesoMax < 50)
        {
            Console.WriteLine($"Escreva o nome da caixa: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Escreva o peso total da caixa: ");
            double peso = double.Parse(Console.ReadLine());

            PesoMax += peso;

            if(PesoMax > 50)
                Console.WriteLine($"Não é possível armazenar essa caixa na Pilha! Limite de peso excedido!");
            else
                Caixas.Push(new Caixa(nome, peso));
        }
    }
}