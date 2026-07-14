// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Models;










//______________________________________________________________________________________________________________________________________________________
                        //    SESSÃO SOBRE VARIAVEIS DINAMICAS
dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variavel {variavelDinamica.GetType()}, valor: {variavelDinamica}");


variavelDinamica = "Texto";

Console.WriteLine($"Tipo da variavel {variavelDinamica.GetType()}, valor: {variavelDinamica}");













//______________________________________________________________________________________________________________________________________________________
//            SESSÃO SOBRE TIPOS READ ONLY

// var tipoAnonimo = new {Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.80};
// Console.Write($"Nome: {tipoAnonimo.Nome} Sobrenome: {tipoAnonimo.Sobrenome} Altura:  {tipoAnonimo.Altura}");
//


//______________________________________________________________________________________________________________________________________________________
            //SESSÃO SOBRE A DESSERIALIZAÇÃO DE UM OBJETO USANDO FOREACH 
// string conteudo = File.ReadAllText("Arquivos/vendas.json");
// List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudo);
//
// foreach (Vendas venda in listaVendas)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda}, Desconto: {venda.Desconto}");
// }


//______________________________________________________________________________________________________________________________________________________

                  //SESSÃO SOBRE SERIALIZAÇÃO DE UM OBJETO, TRANSFORMA-LO EM JSON PARA QUE SEJA COMPATIVEL COM UM BANCO DE DADOS OU OUTROS PROGRAMAS
// DateTime dataVenda = DateTime.Now;
//
                  
// List<Vendas> listaVendas  = new List<Vendas>();
// Vendas v1 = new Vendas(1, "material", 126.45m, dataVenda, 14);
// Vendas v2 = new Vendas(2, "carro", 12226.45m, dataVenda, null );

// listaVendas.Add(v1);
// listaVendas.Add(v2);


// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado);
// Console.WriteLine(serializado);





//______________________________________________________________________________________________________________________________________________________
//                sessão sobre tipos ANONIMOS
 // string conteudo = File.ReadAllText("Arquivos/vendas.json");
 // List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudo);
 // var listaAnonimo = listaVendas.Select(x => new {x.Produto, x.Preco}) ;
 //
 //  foreach (var venda in listaAnonimo)
 //  {
 //     Console.WriteLine( $"Produto: {venda.Produto}, Preço: {venda.Preco}" );
 //  }
 //



//______________________________________________________________________________________________________________________________________________________
//                  SESSÃO SOBRE TIPOS DINAMICOS


//______________________________________________________________________________________________________________________________________________________

          //SESSÃO SOBRE VALORES NULOS
// bool? desejaReceberEmail = false;
//
// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("email enviado"); 
// }
//
// else 
// {
//     Console.WriteLine("opção nula ou não deseja receber email");
// }





