using System;

class Jogador
{
    private string _nome;
    private int _idade;

    private string _nacionalidade;
    private string _posicao;

    public Jogador()
    {
    }


    public string Nome
    { 
        get => _nome;


        set
        {
            
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("nome não pode ser vazio");
            }
            
            _nome = value;
            
        } 
        
        
    }
    public string Nacionalidade
    { 
        get => _nacionalidade;


        set
        {
            
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Nacionalidade não pode ser vazio");
            }
            
            _nacionalidade = value;
            
        } 
        
        
    }
    public int Idade
    { 
        get => _idade; 
    
    
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("idade não pode ser menor que zero");
            }

            _idade = value;

        } 
        
    }
    public string Posicao
    { 
        get => _posicao;


        set
        {
            
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Posição não pode ser vazio");
            }
            
            _posicao = value;
            
        } 
        
        
    }

    



    
}

class Program
{
    static void Main()
    {
        Jogador j = new Jogador();
        j.Nome = Console.ReadLine();
        j.Nacionalidade = Console.ReadLine();
        j.Idade = int.TryParse(Console.ReadLine());
        j.Posicao = Console.ReadLine();
        Console.WriteLine("Jogador criado!");
        Console.WriteLine(j.Nome);
        Console.WriteLine(j.Nacionalidade);
        Console.WriteLine(j.Idade);
        Console.WriteLine($"Posição: {j.Posicao}");
        

        
    }
}