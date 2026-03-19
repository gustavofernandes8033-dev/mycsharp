
using System.Linq.Expressions;
using ListadeTarefas.Services;

List<Tarefa> listaTarefa = new();

static void SeEstaVazioRepetir(string input)
{

     while (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Este valor não pode ser nulo");
        break;
    }
}

static void SeDataInvalidaRepetir(string dataInput, DateOnly dataValidada)
{


  while (!DateOnly.TryParse( dataInput, out dataValidada))
  {
    
    Console.WriteLine("data inválida"); 
    break;
  }

}

static void ListarTarefas()
{

  
}
Console.WriteLine("Bem vindo a sua lista de tarefas :3");
Console.WriteLine("O que gostaria de fazer?");


bool exibirMenu = true;
DateOnly dataDeHoje = DateOnly.FromDateTime(DateTime.Today);
while(exibirMenu) 
{
    Console.Clear();
    Console.WriteLine("1: Registrar nova tarefa");
    Console.WriteLine("2: Consultar tarefas");
    Console.WriteLine("3: Alterar tarefas");
    Console.WriteLine("4: Encerrar o Programa?");
    Console.WriteLine(DateOnly.FromDateTime(DateTime.Today));


    switch (Console.ReadLine())
    {
      case "1":
      string nomeTarefaInput = "";
      string descricaoTarefaInput = "";
      string dataAlvoInput = "";
      DateOnly dataAlvoValida = default;

       do
       {
          Console.WriteLine("Porfavor nomeie sua tarefa!");
          nomeTarefaInput = Console.ReadLine();
          SeEstaVazioRepetir(nomeTarefaInput);
       } while (string.IsNullOrWhiteSpace(nomeTarefaInput));

       Console.WriteLine("Adicione uma descrição a sua tarefa (opcional)");
       descricaoTarefaInput = Console.ReadLine();


       //TODO: dataAlvoInput não pode ser um texto qualquer, nem numero qualquer e nem nulo
       //desenvolver um validador que só deixa passar valores como xx/xx/xxxx

        do
        {
          Console.WriteLine("Em qual data deseja ser lebrado de sua tarefa?");
          dataAlvoInput = Console.ReadLine();
          SeEstaVazioRepetir(dataAlvoInput);
          SeDataInvalidaRepetir(dataAlvoInput, dataAlvoValida);

        } while( string.IsNullOrWhiteSpace(dataAlvoInput) ||  !DateOnly.TryParse( dataAlvoInput, out dataAlvoValida));


        Tarefa tar = new Tarefa(nomeTarefaInput, descricaoTarefaInput, dataDeHoje, dataAlvoValida);
        listaTarefa.Add(tar);

        tar.ApresentarNomeTarefa();
        
        break;

        case "2":
        Console.WriteLine("Estas são as tarefas presentes");
        
        foreach(item tarefa in listaTarefa)
        {
          
        }  



        break;

        case "3":
        Console.WriteLine("Opção 3 selecionada");
        break;

        case "4":
            Console.WriteLine("O programa será encerrado!");
            Console.WriteLine("Tem certeza que quer encerrar o programa?");
            if(Console.ReadLine() == "y" || Console.ReadLine() == "s")
            {
                exibirMenu = false;
                break;
            }
            
            break;
            

        default:
            Console.WriteLine("Opção inválida");
            break;



    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
    
    

    




