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

        private double _note;
        [Range(0.0, 5.0, ErrorMessage = "vous devez entrer une valeur entre 0.0 et 5.0 inclusivement")]
        public double Note
        {
            get => _note;
            set => _note = Math.Clamp(value, 0.0, 5.0);
        }
        public string Ville { get; set; }
    }
}
