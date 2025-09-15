using Microsoft.AspNetCore.Mvc;

namespace GestaoDeEstacionamento.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DetalhesVeiculoController : Controller
    {
        private readonly ILogger<DetalhesVeiculoController> _logger;

        public DetalhesVeiculoController(ILogger<DetalhesVeiculoController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View();

        }
    }
}
