using System;
using System.Security.Cryptography.X509Certificates;
using cursoDIO.Models;

class Program
{

    static void Main()
    {


        Console.WriteLine("digita algo ai");

        string variavel = Console.ReadLine();
        Console.WriteLine(variavel);



/*

//primeiro elemento é a chave, segundo é o valor.
//                   |       |
//                   V1      V2
        Dictionary<string, string> capitais = new Dictionary<string, string>();

        capitais.Add("SP", "São Paulo");
        capitais.Add("BA", "Salvador");
        capitais.Add("MG", "Belo Horizonte");
        capitais.Add("FR(França)", "Paris");

        foreach(var item in capitais) {
                Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
        }

        
        quando o assunto é dictionary: chaves são unicas. 
        ou seja, se eu fizer o comando capitais.Add("MG", "Minas Gerais"); novamente o compilador me joga uma exeção.
        isso garante que as chaves sejam unicas.
         

        Console.WriteLine("Removendo o estado da bahia simplesmente com a chave *BA*");
        capitais.Remove("BA");

        foreach(var item in capitais) {
                Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
        }

        Console.WriteLine("Alterando o a capital França atravez de sua chave. Alterando valor para 'valor alterado'");
        
        capitais["FR(França)"] = "valor alterado";

        foreach(var item in capitais) {
                Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
        }


 */
        















/*
        Stack<int> pilha = new Stack<int>();

        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(3);
        pilha.Push(4);

        foreach(int item in pilha)
        {
                Console.WriteLine(item);
        }

        Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");
        pilha.Push(5);

        foreach(int item in pilha)
        {
                Console.WriteLine(item);
        }

/*


        














/*
        Queue<int> fila = new Queue<int>();
        fila.Enqueue(1);
        fila.Enqueue(2);
        fila.Enqueue(3);
        fila.Enqueue(4);

        foreach(int item in fila)
        {
                Console.WriteLine(item);
        } 

        Console.WriteLine($"Removendo o elemento: {fila.Dequeue()} ");
        fila.Enqueue(1);

        foreach(int item in fila)
        {
                Console.WriteLine(item);
        }


*/
/*

        ExemploExecao teste = new ExemploExecao();

        teste.Metodo1();

*/













       try //invocando os chamados de exeção "try/catch"
       {
                string[] linhas = File.ReadAllLines("Arquivos/teste__.txt"); //criando um vetor para armazenar cada linha em um local na memoria
                foreach(string linha in linhas ) // percorrendo cada elemento no vetor
                {
                        Console.WriteLine(linha); // imprimindo os elementos no vetor
                        
                }

                
        } catch(FileNotFoundException uno){ //chamando a funcao catch e nomeando essa excecão de uno
                Console.WriteLine($"ae burrão ta errado o nome do arquivo aí meo. {uno.Message}"); //exibindo mensagem de uno
                        
        } catch(DirectoryNotFoundException dos){ //chamando a funcao catch e nomeando essa excecão de dos
                Console.WriteLine($"ae burrão não achou a pasta aí não burrão. {dos.Message}");
                        
        } catch(Exception tres){//chamando a funcao catch e nomeando essa excecão de uno
                Console.WriteLine($"ae burrão... deu algo errado aí irmão se vira aí tlg.... {tres.Message}");
                        
        }

        finally
        {
                Console.Write("vai continua aí doido"); 
        }

   


        




        
   /*
        Pessoa p1 = new Pessoa("guga");
        Aluno a1 = new Aluno("tata");

        a1.Idade = 23;
        a1.Nota = 12.3;
        a1.Apresentar();
 */










/*        
        Corrente c = new Corrente();

        c.Creditar(500);

        c.ExibirSaldo();

*/






































/*
          
        Pessoa p1 = new Pessoa(nome:"gusta",sobrenome: "ferna");
        
        
        Pessoa p2 = new Pessoa(nome:"Eduardo",sobrenome: "Cuzudo");
        

        Curso cursoIngles = new Curso();

        cursoIngles.Nome = "Ingles";
        cursoIngles.Alunos = new List<Pessoa>();

        cursoIngles.AdicionarAluno(p1);
        cursoIngles.AdicionarAluno(p2);
        cursoIngles.ListarAlunos();
*/


        
    }

    
	
  

}

