using System.Collections;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Socio
{
    public int NrCota { get; set; }
    public string NomeSócio { get; set; } = string.Empty; 
    public string DataNasc { get; set; } = string.Empty; 
    public string DataAquisição { get; set; } = string.Empty;   

    public void entraDados()
    {
        Console.Clear();
        Console.WriteLine($"Cadastro de sócio: ");

        Console.WriteLine($"<====================>");

        Console.WriteLine($"Número da cota: ");
        NrCota = int.Parse(Console.ReadLine());

        Console.WriteLine($"Nome do sócio: ");
        NomeSócio = Console.ReadLine();

        Console.WriteLine($"Data de nascimento: ");
        DataNasc = Console.ReadLine();

        Console.WriteLine($"Data de aquisição da cota: ");
        DataAquisição = Console.ReadLine();
    }
}

class Dependente
{
    public int NrCota { get; set; }
    public string NomeDependente { get; set; } = string.Empty;
    public string DataNasc { get; set; } = string.Empty;

    public void EntraDados(int cota)
    {
        NrCota = cota;

        Console.WriteLine("\nNome do dependente: ");
        NomeDependente = Console.ReadLine();

        Console.WriteLine("\nData de nascimento: ");
        DataNasc = Console.ReadLine();

    }

}
class Program
{
    public static void Main()
    {
        ArrayList CadSócio = new ArrayList();
        ArrayList CadDependente = new ArrayList();

        Socio S;
        Dependente D;

        do
        {
            S = new Socio();
            S.entraDados();
            CadSócio.Add(S);
            Console.Write("\n Possui dependentes? (S/N)");
            if (Console.ReadKey(false).Key == ConsoleKey.S)
            {
                do
                {
                    D = new Dependente();
                    D.EntraDados(S.NrCota);
                    CadDependente.Add(D);

                    Console.WriteLine($"Tem outro dependente? (S/N)");
                } while (Console.ReadKey(false).Key == ConsoleKey.S);
            }
        } while (Console.ReadKey(false).Key == ConsoleKey.S);


        foreach (Socio xSocio in CadSócio)
        {
            Console.WriteLine($"\n{xSocio.NrCota} - {xSocio.NomeSócio}");
            Console.WriteLine($"\n Data de nascimento: {xSocio.DataNasc}");
            Console.WriteLine($"\n Aquisição da cota: {xSocio.DataAquisição}");

            foreach (Dependente xDependente in CadDependente)
            {
                if (xSocio.NrCota == xDependente.NrCota)
                {
                    Console.WriteLine($"\nDependente do sócio {xSocio.NomeSócio}: {xDependente.NomeDependente}");
                    Console.WriteLine($"Data de nascimento do dependente: {xDependente.DataNasc}");
                }
            }

            Console.ReadKey();
        }
        
    }
}
