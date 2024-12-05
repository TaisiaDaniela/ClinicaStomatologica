using System.ComponentModel.DataAnnotations;

namespace ClinicaStomatologica.Models
{
    public class Serviciu
    {
        public int ID { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string? Denumire { get; set; }
        public ICollection<DoctorServiciu>? DoctorServicii { get; set; }


    }
}