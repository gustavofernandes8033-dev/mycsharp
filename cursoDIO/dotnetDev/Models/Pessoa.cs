using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Representa pessoa fisica
    /// </summary>
    public class Pessoa
    {  

       
        private string _nome;
        private string _sobrenome;

        public Pessoa(string nome, string sobrenome)
        {
           Nome = nome;
           Sobrenome = sobrenome;
                  
        } 

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }




        private int _idade;
        public string Nome 
        {
            get => _nome;
             

            set // atribuir um valor
            {
                if(value == "")
                {
                    throw new ArgumentException("nome não pode ser vazio");
                }

                _nome = value;
            }
        }

	public string Sobrenome
    {
            get => _sobrenome.ToUpper(); // obter um valor
             

            set // atribuir um valor
            {
                if(value == "")
                {
                    throw new ArgumentException("nome não pode ser vazio");
                }

                _sobrenome= value;
            }
        }
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
