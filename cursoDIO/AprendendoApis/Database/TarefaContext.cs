using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TarefasContext : DbContext
{

    #nullable disable
    public TarefasContext(DbContextOptions<TarefasContext> options) : base(options);
    public DbSet<Tarefa> Tarefas {get;set;}

}

