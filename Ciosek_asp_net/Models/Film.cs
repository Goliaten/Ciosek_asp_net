using System.ComponentModel.DataAnnotations;

namespace Ciosek_asp_net.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string Tytul { get; set; }
        public int Rezyser { get; set; }
        public int Opis{ get; set; }
        public int Cena { get; set; }
        public int Data_dodania{ get; set; }
        //cena, data dodania
    }
}
