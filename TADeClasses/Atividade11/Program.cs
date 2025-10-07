class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine($"Escreva até qual termo da sequência você quer: ");
        n = int.Parse(Console.ReadLine()); //Pega o termo que ele quer 
        int numero = Fibonacci(n);
        Console.WriteLine($"O termo {n} da sequência de Fibonacci é o: {numero}");
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}