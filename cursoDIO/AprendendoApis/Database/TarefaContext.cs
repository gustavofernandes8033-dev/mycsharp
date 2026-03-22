using System.Diagnostics;

public class TarefasContext : DbContext
{

    #nullable disable
    public TarefasContext(DbContextOptions<TarefasContext> options) : base(options);
    public DbSet<Tarefa> Tarefas {get;set;}

}

