using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ciosek_asp_net.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tytuł jest wymagany")]
        public string? Tytul { get; set; }
        public string? Rezyser { get; set; }
        [StringLength(500, ErrorMessage = "Za długi opis")]
        public string? Opis { get; set; }
        [Required(ErrorMessage = "Cena jest wymagana")]
        public decimal Cena { get; set; }
        public DateTime Data_dodania{ get; set; }

        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
