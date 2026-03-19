using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDIO.Models
{
    public class Professor : Pessoa
    {

        public Professor (string nome) : base (nome)
        {

        }


        public decimal salario { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade}, ganho R${salario} ao mês");
        }
    }
}