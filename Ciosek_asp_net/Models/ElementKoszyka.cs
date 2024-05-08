using System.ComponentModel.DataAnnotations;

namespace Ciosek_asp_net.Models
{
    public class ElementKoszyka
    {
        [Required]
        public Film film { get; set; }
        public int ilosc { get; set; }
        public decimal wartosc { get; set; }
    }
}
