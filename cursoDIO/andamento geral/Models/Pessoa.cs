using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDIO.Models
{
    public class Pessoa
    {  

       
        private string _nome;

        public Pessoa(string nome)
        {
           Nome = nome;
                  
        } 




        private int _idade;
        public string Nome 
        {
            get => _nome.ToUpper(); // obter um valor
             

            set // atribuir um valor
            {
                if(value == "")
                {
                    throw new ArgumentException("nome não pode ser vazio");
                }

                _nome = value;
            }
        }

	public string Sobrenome {get; set;}
	public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();


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
        
        public virtual void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
