namespace Ciosek_asp_net.Models
{
    public class DodawanieFilmow
    {
        public Film film{ get; set; }
        public IFormFile plakat { get; set; }
        public List<Kategoria> kategorie { get; set; }

    }
}
