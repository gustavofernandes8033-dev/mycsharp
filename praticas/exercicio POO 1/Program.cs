using System;
using System.ComponentModel;


// objetivos: fazer uma validação de dados.
//              e fazer com que o exeption do get funcione


class Pessoa
{

    public Pessoa()
    {
        
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    
 

    private string _nome;

    private int _idade;

    

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

    public string GetNome()
    {
        
        Nome = Console.ReadLine();
        return Nome;
    }

    public int GetIdade()
    {
        
        Idade = Convert.ToInt32(Console.ReadLine());
        return Idade;
    }
}

class Program
{
    static void Main()
    {
       Pessoa p = new Pessoa();
       p.GetNome();
       p.GetIdade();

       Console.WriteLine("pqp essa porra ta funcionando ou não?");
       Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade} ");

    }
}

