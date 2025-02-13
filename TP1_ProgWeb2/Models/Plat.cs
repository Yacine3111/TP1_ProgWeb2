namespace TP1_ProgWeb2.Models
{
    public class Plat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public string Categorie { get; set; }
        public string CheminImage { get; set; }
        public int RestaurantId { get; set; }

    }
}
