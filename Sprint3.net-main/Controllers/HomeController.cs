using Microsoft.AspNetCore.Mvc;
using Sprint3.Models;
using System.Diagnostics;

namespace Sprint3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult RMs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult TendenciasGastos()
        {
            return View();
        }

        // GET: DesempenhoFinanceiro
        public ActionResult DesempenhoFinanceiro()
        {

            return View();
        }

        public ActionResult ComportamentoNegocios()
        {
            var Cn = new ComportamentoNegocios
            {
                Id = 1,
                InteracoesPlataforma = 100,
                FrequenciaUso = 12,
                Feedback = "Excelente",
                UsoRecursosEspecificos = "Relatórios e Análises"
            };
            return View(Cn);
        }
    }
}
