using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    ///cool 
    /// </summary>
    public class Curso
    {
        private string _nome;
        public Curso(string nome)
        {
            Nome = nome;
        }
        
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