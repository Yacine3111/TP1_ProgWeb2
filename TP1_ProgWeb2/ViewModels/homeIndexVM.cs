using TP1_ProgWeb2.Models;

namespace TP1_ProgWeb2.ViewModels
{
    public class HomeIndexVM
    {
        public IList<Restaurant> restaurants = new List<Restaurant>();
        public IList<Plat> plats = new List<Plat>();

    }
}
