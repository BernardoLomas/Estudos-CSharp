using Microsoft.Win32.SafeHandles;

class Program
{
    private static void Main(string[] args)
    {
        int contM = 0, contF = 0;
        char[] pessoas = new char[15];

        for (int i = 0; i < pessoas.Length; i++)
        {
            Console.WriteLine($"Digite o sexo da pessoa {i + 1}/15 :");
            pessoas[i] = char.Parse(Console.ReadLine());
            if (pessoas[i] == 'M')
                contM++;

            else if (pessoas[i] == 'F')
                contF++;

            else
                Console.WriteLine("Valor inválido.");
        }

        Console.Clear();

        //Resultados
        var (homens, mulheres, maior, menor) = VetoresSexo(contF, contM);
        Console.WriteLine($"O maior do grupo tem {maior.ToString("F2")} metro(s) de altura.");
        Console.WriteLine($"O menor do grupo tem {menor.ToString("F2")} metro(s) de altura.");

        double mediaM = MediaMulheres(contF, mulheres);
        Console.WriteLine($"A média de altura das mulheres é: {mediaM}.");

        Console.WriteLine($"A quantidade de homens é: {contM}.");
    }

    //Cálculo de maior e menor com tuplas
    static (double[] homens, double[] mulheres, double maiorGeral, double menorGeral) VetoresSexo(int contF, int contM)
    {
        double[] homens = new double[contM];
        double[] mulheres = new double[contF];
        double maiorHomem = 0, menorHomem = double.MaxValue;
        double maiorMulher = 0, menorMulher = double.MaxValue;
        double maiorGeral, menorGeral;

        for (int i = 0; i < homens.Length; i++)
        {
            Console.WriteLine($"Altura do homem: {i + 1}/{contM}");
            homens[i] = double.Parse(Console.ReadLine());

            if (homens[i] > maiorHomem)
                maiorHomem = homens[i];

            if (homens[i] < menorHomem)
                menorHomem = homens[i];
        }

        for (int i = 0; i < mulheres.Length; i++)
        {
            Console.WriteLine($"Altura da mulher: {i + 1}/{contF}");
            mulheres[i] = double.Parse(Console.ReadLine());

            if (mulheres[i] > maiorMulher)
                maiorMulher = mulheres[i];

            if (mulheres[i] < menorMulher)
                menorMulher = mulheres[i];
        }

        Console.Clear();

        if (maiorHomem > maiorMulher)
            maiorGeral = maiorHomem;
        else
            maiorGeral = maiorMulher;

        if (menorHomem < menorMulher)
            menorGeral = menorHomem;
        else
            menorGeral = menorMulher;

        return (homens, mulheres, maiorGeral, menorGeral);
    }


    //Média de altura das mulheres
    static double MediaMulheres(int contF, double[] mulheres)
    {
        double soma = 0;

        for (int i = 0; i < mulheres.Length; i++)
        {
            soma += mulheres[i];
        }

        double media = soma / mulheres.Length;

        return media;
    }



}