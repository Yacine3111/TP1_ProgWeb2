using Microsoft.AspNetCore.Mvc;
using TP1_ProgWeb2.Models;

namespace TP1_ProgWeb2.Controllers
{
    public class PlatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public static IList<Plat> GeneratePlats()
        {
            return
            [
            new Plat() { Id = 1, Nom = "Foie Gras", Prix = 25.99, Categorie = "Entrée", CheminImage = "", RestaurantId = 1 },

            new Plat() { Id = 2, Nom = "Pâtes Carbonara", Prix = 14.50, Categorie = "Plat principal", CheminImage = "", RestaurantId = 2 },

            new Plat() { Id = 3, Nom = "Sushi Assorti", Prix = 18.00, Categorie = "Plat principal", CheminImage = "", RestaurantId = 3 }
            ,
            new Plat() { Id = 4, Nom = "Paella", Prix = 22.75, Categorie = "Plat principal", CheminImage = "", RestaurantId = 4 },

            new Plat() { Id = 5, Nom = "Cheeseburger", Prix = 12.99, Categorie = "Plat principal", CheminImage = "", RestaurantId = 5 },

            new Plat() { Id = 6, Nom = "Poulet au beurre", Prix = 15.50, Categorie = "Plat principal", CheminImage = "", RestaurantId = 6 },

            new Plat() { Id = 7, Nom = "Escargots", Prix = 19.99, Categorie = "Entrée", CheminImage = "", RestaurantId = 1 },

            new Plat() { Id = 8, Nom = "Tiramisu", Prix = 8.50, Categorie = "Dessert", CheminImage = "", RestaurantId = 2 },

            new Plat() { Id = 9, Nom = "Ramen", Prix = 13.75, Categorie = "Plat principal", CheminImage = "", RestaurantId = 3 },

            new Plat() { Id = 10, Nom = "salade de choux", Prix = 17.25, Categorie = "Entrée", CheminImage = "", RestaurantId = 4 },

            new Plat() { Id = 11, Nom = "Hot Dog", Prix = 9.50, Categorie = "fast food", CheminImage = "", RestaurantId = 5 },

            new Plat() { Id = 12, Nom = "Gulab Jamun", Prix = 6.99, Categorie = "Dessert", CheminImage = "", RestaurantId = 6 },

            new Plat() { Id = 13, Nom = "Coq au Vin", Prix = 23.50, Categorie = "Plat principal", CheminImage = "", RestaurantId = 1 },

            new Plat() { Id = 14, Nom = "Pizza", Prix = 11.99, Categorie = "Plat principal", CheminImage = "", RestaurantId = 2 },

            new Plat() { Id = 15, Nom = "Tempura", Prix = 14.99, Categorie = "Entrée", CheminImage = "", RestaurantId = 3 }
            ];
        }
    }
}