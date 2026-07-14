namespace api_com_buta;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities




    


public class AgendaContext.cs : DbContext
{
	public AgendaContext(DbContextOption <AgendaContext> options) : base(options)
	{

	}

	public DbSet<Contato> Contatos {get; set;} 
	
}
