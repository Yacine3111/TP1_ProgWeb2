using TP1_ProgWeb2.Models;

namespace TP1_ProgWeb2.ViewModels
{
    public class AcceuilIndexVM
    {
        public IList<Restaurant> restaurants = new List<Restaurant>();
        public IList<Plat> plats = new List<Plat>();

    }
}
