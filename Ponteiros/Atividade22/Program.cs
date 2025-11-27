class Pessoa
{
    public string Nome {get; set;}
    public int Idade {get; set;}
    public Pessoa Proximo {get; set;}

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Proximo = null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Escreva quantas pessoas deseja cadastrar: ");
        int quantidade = int.Parse(Console.ReadLine());

        Pessoa Primeiro = null;
        Pessoa Ultimo = null;

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            
            Pessoa novo = new Pessoa(nome, idade);

            if(Primeiro == null)
            {
                Primeiro = novo; //Se primeiro for null, a primeira idade é inserida na lista
            }
            else if (idade < Primeiro.Idade) //Se primeiro não for null, comparamos se a idade da respectiva pessoa é menor que a do Primeiro
            {
                novo.Proximo = Primeiro; //Se for menor, Primeiro é empurrado para frente, pois tem que dar lugar a uma idade menor
                Primeiro = novo; //A nova idade se torna primeiro e organiza a lista
            }
            else // Se a atual idade não for menor, deve ser adicionada na frente
            {
                Pessoa Atual = Primeiro;  // Usamos Primeiro como referência para percorrer a lista e ver onde ela deve ser encaixada

                while(Atual.Proximo != null && Atual.Proximo.Idade < idade) //Enquanto Atual.Proximo for diferente de null e Atual.Proximo tiver a idade menor que a respectiva criada no for
                {
                    Atual = Atual.Proximo; // Faz a lista andar
                }

                novo.Proximo = Atual.Proximo; // Quando achar o lugar certo, novo.proximo recebe a posição de atual.proximo
                Atual.Proximo = novo; // Atual.proximo recebe o valor de novo e a lista estará ordenada
            }
        }

        Pessoa Aux = Primeiro;
        while(Aux != null)
        {
            Console.WriteLine($"Nome: {Aux.Nome} | Idade: {Aux.Idade}");
            Aux = Aux.Proximo;
        }
    }
}