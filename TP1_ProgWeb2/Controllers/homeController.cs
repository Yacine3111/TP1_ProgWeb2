using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP1_ProgWeb2.Models;
using TP1_ProgWeb2.ViewModels;

namespace TP1_ProgWeb2.Controllers
{
    public class homeController : Controller
    {
        private readonly ILogger<homeController> _logger;

        public homeController(ILogger<homeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new homeIndexVM() { restaurants = getTopRestaurants(), plats = getLowestPrice() });
        }

        private IList<Restaurant> getTopRestaurants()
        {
            var restaurents = RestaurantsController.GenerateRestaurants()
                .OrderByDescending(e => e.Note).Take(3).ToList();

            return restaurents;
        }

        private IList<Plat> getLowestPrice()
        {
            var restaurents = PlatsController.GeneratePlats()
                .OrderBy(e => e.Prix).Take(3).ToList();

            return restaurents;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
