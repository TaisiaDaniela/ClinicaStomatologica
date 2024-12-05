namespace ClinicaStomatologica.Models
{
    public class DoctorServiciu
    {
        public int ID { get; set; }

        public int DoctorID { get; set; }

        public Doctor Doctor { get; set; }

        public int ServiciuID { get; set; }

        public Serviciu Serviciu { get; set; }
    }
}
