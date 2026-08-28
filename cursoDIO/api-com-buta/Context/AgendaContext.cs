using Microsoft.EntityFrameworkCore;
using api_com_buta.Entities;




namespace api_com_buta.Context;

public class AgendaContext : DbContext
{
  public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
  {

  }

  public DbSet<Contato> Contatos{get; set;}

}
