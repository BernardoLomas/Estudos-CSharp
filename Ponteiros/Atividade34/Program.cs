class Numero
{
    public int Num {get; set;}
    public Numero Proximo { get; set; }
    public Numero Anterior { get; set; }

    public Numero(int numero)
    {
        Num = numero;
        Proximo = null;
        Anterior = null;
    }
}
class Program
{
    public static void Main()
    {
        Console.WriteLine($"Escreva a quantidade de números na lista: ");
        int quantidade = int.Parse(Console.ReadLine());

        Numero Primeiro = null;
        Numero Ultimo = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Número {i + 1}/{quantidade}:");
            int numero = int.Parse(Console.ReadLine());

            Numero novo = new Numero(numero);

            if(Primeiro == null)
            {
                Primeiro = novo;
                Ultimo = novo;
            }
            else
            {
                novo.Proximo = Primeiro;
                Primeiro.Anterior = novo;
                Primeiro = novo;
            }
        }

        Numero Atual = Primeiro;
        while(Atual != null)
        {
            Console.WriteLine($"Número: {Atual.Num}");
            Atual = Atual.Proximo;
        }
    }
}