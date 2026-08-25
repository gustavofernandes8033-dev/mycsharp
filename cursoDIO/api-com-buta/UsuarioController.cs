using Microsoft.AspNetCore.Mvc;

namespace api_com_buta;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{

  [HttpGet("ObterDataHoraAtual")]
  public IActionResult ObterDataHora()
  {
    var obj = new 
    {
      Data = DateTime.Now.ToLongDateString(),
      Hora = DateTime.Now.ToShortTimeString()

    };

    return Ok(obj);

  }



}
