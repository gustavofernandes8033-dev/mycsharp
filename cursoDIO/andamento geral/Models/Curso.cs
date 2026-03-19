using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDIO.Models
{
    public class Curso
    {
        private string _nome;
        
        public string Nome { get; set; }
        public List<Pessoa> Alunos 
        { 
            get;
            set; 
        }


        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

       public int QuantidadeDeAlunos()
        {
            return Alunos.Count;
        }

        public void ListarAlunos()
        {
            foreach(Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}