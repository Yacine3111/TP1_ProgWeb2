using Microsoft.AspNetCore.Mvc;
using TP1_ProgWeb2.Models;

namespace TP1_ProgWeb2.Controllers
{
    public class RestaurantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public static IList<Restaurant> GenerateRestaurants()
        {
            return
            [
                new Restaurant() { Id = 1, Nom = "Le Gourmet", Adresse = "12 Rue de Paris", Telephone = "438-904-1930", Cuisine = "Française", Note = 5.0, Ville = "Paris" },
                new Restaurant() { Id = 2, Nom = "Pasta Bella", Adresse = "34 Via Roma", Telephone = "514-568-1985", Cuisine = "Italienne", Note = 4.3, Ville = "Rome" },
                new Restaurant() { Id = 3, Nom = "Sushi Zen", Adresse = "56 Shibuya", Telephone = "418-248-1003", Cuisine = "Japonaise", Note = 4.7, Ville = "Tokyo" },
                new Restaurant() { Id = 4, Nom = "El Toro Loco", Adresse = "78 Calle Mayor", Telephone = "514-789-1234", Cuisine = "Espagnole", Note = 1.2, Ville = "Madrid" },
                new Restaurant() { Id = 5, Nom = "Burger House", Adresse = "90 Broadway", Telephone = "450-147-9630", Cuisine = "Américaine", Note = 3.4, Ville = "New York" },
                new Restaurant() { Id = 6, Nom = "Curry Palace", Adresse = "23 MG Road", Telephone = "438-997-2247", Cuisine = "Indienne", Note = 2.6, Ville = "Mumbai" }
            ];
        }

    }
}
