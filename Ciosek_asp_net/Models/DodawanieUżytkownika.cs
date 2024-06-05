using System.ComponentModel.DataAnnotations;

namespace Ciosek_asp_net.Models
{
    public class DodawanieUżytkownika
    {
        [Required(ErrorMessage = "Podaj email")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Podaj nazwę użytkownika")]
        public string userName { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        [Required(ErrorMessage = "Podaj hasło")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Podaj hasło")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Hasła muszą się zgadzać")]
        public string confirmedPassword { get; set; }
    }
}
