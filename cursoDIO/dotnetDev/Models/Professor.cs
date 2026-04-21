using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Professor : Pessoa
    {

        public Professor (string nome, string sobrenome) : base (nome, sobrenome)
        {

        }


        public decimal salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade}, ganho R${salario} ao mês");
        }
    }
}