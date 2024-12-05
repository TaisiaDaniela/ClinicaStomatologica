using System.ComponentModel.DataAnnotations;

namespace ClinicaStomatologica.Models
{
    public class Pacient
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage = "Numele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau AnaMaria")]
        [StringLength(30, MinimumLength = 3)]
        public string? FullName { get; set; }

        public string? Adress { get; set; }
        [Required(ErrorMessage = "Adresa de email este obligatorie.")]
        [EmailAddress(ErrorMessage = "Adresa de email nu este valida.")]
        public string Email { get; set; }

        [RegularExpression(@"^0\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sau'0722.123.123' sau '0722 123 123'")]
        public string? Phone { get; set; }
        [RegularExpression(@"^\d{13}$",
            ErrorMessage = "CNP-ul trebuie sa contina exact 13 cifre.")]
        public string? CNP { get; set; }

        [RegularExpression(@"^[A-Z]{2}$",
            ErrorMessage = "Seria buletinului trebuie sa contina exact 2 litere majuscule.")]
        public string? SerieBuletin { get; set; }

        [RegularExpression(@"^\d{6,8}$",
            ErrorMessage = "Numarul buletinului trebuie sa contina intre 6 si 8 cifre.")]
        public string? NumarBuletin { get; set; }
        public ICollection<Programare>? Programari { get; set; }
    }
}
