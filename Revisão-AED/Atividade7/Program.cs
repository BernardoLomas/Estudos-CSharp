class Program
{
    private static void Main(string[] args)
    {
        var (notas1, notas2, notas3, alunos) = Notas();

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Nota total do aluno {i + 1}/20 : {alunos[i]}");
        }

        var (med1, med2, med3) = Medias(notas1, notas2, notas3);
        Console.WriteLine($"Nota média da turma na prova 1: {med1:F2}");
        Console.WriteLine($"Nota média da turma na prova 2: {med2:F2}");
        Console.WriteLine($"Nota média da turma na prova 3: {med3:F2}");
    }
    static (double[] notas1, double[] notas2, double[] notas3, double[] alunos) Notas()
    {
        double[] alunos = new double[20];
        double[] notas1 = new double[20];
        double[] notas2 = new double[20];
        double[] notas3 = new double[20];
        Random X = new Random();

        for (int i = 0; i < alunos.Length; i++)
        {
            notas1[i] = X.Next(1, 11);
            notas2[i] = X.Next(1, 11);
            notas3[i] = X.Next(1, 11);
            alunos[i] = notas1[i] + notas2[i] + notas3[i];
        }

        return (notas1, notas2, notas3, alunos);
    }


    static (double media1, double media2, double media3) Medias(double[] notas1, double[] notas2, double[] notas3)
    {
        double soma1 = 0, soma2 = 0, soma3 = 0;

        for (int i = 0; i < notas1.Length; i++) soma1 += notas1[i];
        for (int i = 0; i < notas2.Length; i++) soma2 += notas2[i];
        for (int i = 0; i < notas3.Length; i++) soma3 += notas3[i];

        double media1 = (double)soma1 / notas1.Length;
        double media2 = (double)soma2 / notas2.Length;
        double media3 = (double)soma3 / notas3.Length;

        return (media1, media2, media3);
    }
}