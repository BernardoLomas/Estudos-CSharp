class Program
{
    private static void Main(string[] args)
    {
        var (R, S, V) = PreencheVetor();
        Console.WriteLine("R: " + string.Join("- ", R));
        Console.WriteLine("S: " + string.Join("- ", S));
        Console.WriteLine("V (sem repetição): " + string.Join("- ", V));
    }

    static (int[] R, int[] S, int[] V) PreencheVetor()
    {
        int[] R = new int[10];
        int[] S = new int[10];
        Random X = new Random();

        for (int i = 0; i < R.Length; i++)
            R[i] = X.Next(1, 50);

        for (int k = 0; k < S.Length; k++)
            S[k] = X.Next(1, 50);


        int[] Vtemporario = new int[R.Length + S.Length];
        int qtd = 0;

        for (int i = 0; i < R.Length; i++)
        {
            if (!ExisteNoV(Vtemporario, qtd, R[i]))
            {
                Vtemporario[qtd] = R[i];
                qtd++;
            }
        }

        for (int i = 0; i < S.Length; i++)
        {
            if (!ExisteNoV(Vtemporario, qtd, S[i]))
            {
                Vtemporario[qtd] = S[i];
                qtd++;
            }
        }

        int[] V = new int[qtd];
        for (int i = 0; i < qtd; i++)
            V[i] = Vtemporario[i];

        return (R, S, V);
    }

    static bool ExisteNoV(int[] V, int tamanho, int valor)
    {
        for (int i = 0; i < tamanho; i++)
            if (V[i] == valor)
                return true;

        return false;
    }

}