using aprendendo_apis.ModelViews;
using Microsoft.AspNetCore.Mvc;

namespace aprendendo_apis.Controllers;


[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public HomeView Index()
    {
        return new HomeView
        {
            Mensagem = "Bem vindo ao mundo rest",
            Documentacao = "/swagger"
        };
    }
}
