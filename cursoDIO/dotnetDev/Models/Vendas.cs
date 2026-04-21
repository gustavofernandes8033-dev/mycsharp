using Newtonsoft.Json;
using System.Data.Common;

namespace Models;

public class Vendas
{
    public Vendas(int id, string produto, decimal preco, DateTime dataVenda, decimal? desconto)
    {
        Id = id;
        Produto = produto;
        Preco = preco;
        DataVenda = dataVenda;
        Desconto = desconto;
    }
    public int Id {get; set;}
    public string Produto{get; set;}
    public decimal Preco{get; set;}
    public DateTime DataVenda{get; set;}
    public decimal? Desconto{get; set;}







}
