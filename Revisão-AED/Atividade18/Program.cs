class Matriz
{
    public int L { get; set; }
    public int C { get; set; }
    public int N { get; set; }

    public Matriz(int L, int C, int N, int[,] M, int[,] LC, int[,] Randomica)
    {
        this.L = L;
        this.C = C;
        this.N = N;
        this.M = new int[10, 10];
        this.LC = new int[L, C];
        this.Randomica = new int[L, C];
        
        for (int i = 0; i < L; i++)
        {
            for (j = 0; j < C; j++)
            {
                Randomica[i, j] = R.Next(1, N + 1);
            }
        }
    }

    
    
    public Matriz DiagPrinc(Matriz matriz)
    {

    }
}

class Program
{
    static void Main()
    {
        Matriz m = new Matriz();
    }
}