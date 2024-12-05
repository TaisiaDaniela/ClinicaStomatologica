using System.ComponentModel.DataAnnotations;

namespace ClinicaStomatologica.Models
{
    public class Specializare
    {
        public int ID { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string? Denumire { get; set; }
    }
}
