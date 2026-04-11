using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace api_com_buta.Controllers;

[ApiController]
[Route("[Controller]")]
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

    [HttpGet("Apresentar")]
    public IActionResult Apresentar(string nome)
    {
        var mensagem = $"ola {nome}, seja bem vindo";
        return Ok(new Object { mensagem });
    }

}
