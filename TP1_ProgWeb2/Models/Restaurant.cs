using System.ComponentModel.DataAnnotations;

namespace TP1_ProgWeb2.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Cuisine { get; set; }

        [Range(0.0, 5.0)]
        public double Note { get; set; }
        public string Ville { get; set; }
    }
}
