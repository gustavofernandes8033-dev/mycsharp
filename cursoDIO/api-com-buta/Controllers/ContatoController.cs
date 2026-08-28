using Microsoft.AspNetCore.Mvc;

using api_com_buta.Entities;
using api_com_buta.Context;

namespace api_com_buta.Controllers;

[ApiController]
[Route("[controller]")]
public class ContatoController : ControllerBase
{
  private readonly AgendaContext _context;

  public ContatoController(AgendaContext context)
  {
    _context = context;
  }
  [HttpPost]
  public IActionResult Create(Contato contato)
  {
    _context.Add(contato);
    _context.SaveChanges();
    return Ok(contato);
  }


 



}
