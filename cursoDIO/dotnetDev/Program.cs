// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Models;




string conteudo = File.ReadAllText("Arquivos/vendas.json");
List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudo);

foreach (Vendas venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda}, Desconto: {venda.Desconto}");
}



// DateTime dataVenda = DateTime.Now;


// List<Vendas> listaVendas  = new List<Vendas>();
// Vendas v1 = new Vendas(1, "material", 126.45m, dataVenda, 14);
// Vendas v2 = new Vendas(2, "carro", 12226.45m, dataVenda, null );

// listaVendas.Add(v1);
// listaVendas.Add(v2);


// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado);
// Console.WriteLine(serializado);



















// bool? desejaReceberEmail = false;

// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("email enviado");
// }

// else 
// {
//     Console.WriteLine("opção nula ou não deseja receber email");
// }





