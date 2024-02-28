using System.ComponentModel.DataAnnotations;

namespace Ciosek_asp_net.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Rezyser { get; set; }
        public string Opis { get; set; }
        public decimal Cena { get; set; }
        public DateTime Data_dodania{ get; set; }
        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
