using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeTarefas.Services
{
    public class Tarefa
    {
        public enum StatusTarefa
        {

           Aguardando,
           AFazer,  // uma tarefa pode estar em 1 de quatro estados. 
           Atrasada,
           Concluida
            
        }

        private string _nomeTarefa;
        private string? _descricaoTarefa;
        private DateOnly dataDeCriacao = DateOnly.FromDateTime(DateTime.Today);
        private DateOnly _dataAlvo;
        private enum _status; 

        public Tarefa(string nome, string descicaoTarefa, DateOnly dataDeCriacao, DateOnly dataAlvo  )
        {
            Nometarefa = nome;
            DescricaoTarefa = descicaoTarefa;
            DataDeCriacao = DateOnly.FromDateTime(DateTime.Today);
            DataAlvo = dataAlvo;
            
            
        }
        

       public string Nometarefa 
        {
        
            get => _nomeTarefa;
            
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("nome da tarefa não pode ser vazio");
                }
                _nomeTarefa = value;
            } 
        
        
        } 

       public string DescricaoTarefa{ get; set; } 
       public DateOnly DataDeCriacao { get; set ;} 

       public DateOnly DataAlvo
       { 
        
            get => _dataAlvo;
            
            set
            {
                     //TODO VVVV
                if(value <= DateOnly.FromDateTime(DateTime.Today)) //data alvo não pode ser default- necessário verificar se data alvo é vazio. 
                {
                    throw new ArgumentException("Data alvo não pode estar no passado!");
                }
                _dataAlvo = value;
            } 
        
        
        }
       public string Status { get; set; } 

       public void ApresentarNomeTarefa()
       {
         Console.WriteLine(Nometarefa);
       }




    }
}



