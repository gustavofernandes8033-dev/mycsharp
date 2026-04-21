using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDIO.BibliotecaDeClasses.Common.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome): base(nome, sobrenome)
        {
    

        }

        public double Nota {get; set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um aluno nota {Nota} ");
        }


        
    }
}