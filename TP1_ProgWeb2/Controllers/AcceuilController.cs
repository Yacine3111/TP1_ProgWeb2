using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP1_ProgWeb2.Models;

namespace TP1_ProgWeb2.Controllers
{
    public class AcceuilController : Controller
    {
        private readonly ILogger<AcceuilController> _logger;

        public AcceuilController(ILogger<AcceuilController> logger)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
