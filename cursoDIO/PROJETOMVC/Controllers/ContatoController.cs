using Microsoft.AspNetCore.Mvc;
using PROJETOMVC.Context;
using PROJETOMVC.Models;

namespace PROJETOMVC.Controllers;

public class ContatoController : Controller
{

  private readonly AgendaContext _context;

  public ContatoController (AgendaContext context)
  {
    _context = context;
  }

public IActionResult Index()
  {
    var contatos = _context.Contatos.ToList();
    return View(contatos);
  }


  //no mvc é opicional colocar "httpGet". por padrão, um IActionResult sem http vai ser um get."
  public IActionResult Criar()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Criar(Contato contato)
  {
    if (ModelState.IsValid)
    {
      _context.Contatos.Add(contato);
      _context.SaveChanges();
      return RedirectToAction(nameof(Index));
    }
    return View(contato);
  }

}
