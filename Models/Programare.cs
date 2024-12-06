using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using ClinicaStomatologica.Models.ClinicaStomatologica.CustomValidations;
namespace ClinicaStomatologica.Models
{
    public class Programare
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Pacientul este obligatoriu.")]

        public int? PacientID { get; set; }
        public Pacient? Pacient { get; set; }
        [Required(ErrorMessage = "Medicul este obligatoriu.")]

        public int? DoctorID { get; set; }
        public Doctor? Doctor { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Data si ora sunt obligatorii.")]
        [ValidareDataProgramare(ErrorMessage = "Ora trebuie să fie fixă (ex. 10:00, 14:00) și programările sunt permise doar de luni până vineri.")]
        public DateTime DataProgramare { get; set; }

    }

}