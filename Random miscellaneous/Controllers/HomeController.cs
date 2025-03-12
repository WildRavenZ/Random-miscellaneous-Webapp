using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Random_miscellaneous.Models;
using Random_miscellaneous.Data;

namespace Random_miscellaneous.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _dbContext;  // Inyecta el DbContext

        // Constructor con inyección de dependencias
        public HomeController(ILogger<HomeController> logger, MyDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;  // Asignar la instancia de DbContext
        }

        public IActionResult Index()
        {
            var options = _dbContext.Options.ToList();  // Usa el DbContext para obtener datos
            return View(options);  // Pasa los datos a la vista
        }

        public IActionResult Privacy()
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
