using System.ComponentModel.DataAnnotations;

namespace Ciosek_asp_net.Models
{
    public class Kategoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        public string Nazwa { get; set; }
        public string? Opis { get; set; }
        public ICollection<Film> Filmy { get; set; }
    }
}
