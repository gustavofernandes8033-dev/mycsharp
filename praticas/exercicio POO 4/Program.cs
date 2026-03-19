using System;


class Personagem
{
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; } = 1;
    public int Vida { get; set; } = 10;

    public Personagem(string nome, string raca, string classe)
    {
        Nome = nome;
        Raca = raca;
        Classe = classe;
    }

    public void ExibirStatus()
    {
        Console.WriteLine("Status:");
        Console.WriteLine("Nome:" + Nome);
        Console.WriteLine("Raça:" + Raca);
        Console.WriteLine("Classe:" + Classe);
        Console.WriteLine("Nível:" + Nivel);
        Console.WriteLine("Vida:" + Vida);
    }
}



class Program
{
    static void Main()
    {
        string nomeInput = Console.ReadLine();
        Validador(nomeInput);
        string racaInput = Console.ReadLine();
        Validador(racaInput);
        string classeInput= Console.ReadLine();
        Validador(classeInput);
        Personagem perso = new Personagem(nomeInput, racaInput, classeInput);
        perso.ExibirStatus();

                
    }



    static void Validador(string entradaInput)
    {
        do
        {
            if(string.IsNullOrEmpty(entradaInput))
            {
                Console.WriteLine("Valor não pode ser vazio");
                entradaInput = Console.ReadLine();

            }
            
        }while (string.IsNullOrEmpty(entradaInput));
        

        
    }

    
}

