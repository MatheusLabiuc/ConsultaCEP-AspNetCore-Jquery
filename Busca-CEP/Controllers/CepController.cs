using Busca_CEP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Busca_CEP.Controllers
{
    public class CepController : Controller
    {
        private readonly ILogger<CepController> _logger;

        public CepController(ILogger<CepController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}