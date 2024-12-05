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

namespace ClinicaStomatologica.CustomValidations
    {
        public class ValidareDataProgramareAttribute : ValidationAttribute
        {
            public override bool IsValid(object? value)
            {
                if (value is DateTime dataProgramare)
                {
                    // Verifică dacă este sâmbătă sau duminică
                    if (dataProgramare.DayOfWeek == DayOfWeek.Saturday || dataProgramare.DayOfWeek == DayOfWeek.Sunday)
                    {
                        return false; // Invalid dacă este weekend
                    }

                    // Verifică dacă ora este fixă (minute și secunde 0)
                    if (dataProgramare.Minute != 0 || dataProgramare.Second != 0)
                    {
                        return false; // Invalid dacă nu este la o oră fixă
                    }

                    return true; // Valid dacă trece ambele condiții
                }

                return false; // Invalid dacă valoarea nu este un DateTime
            }

            public override string FormatErrorMessage(string name)
            {
                return $"{name} trebuie să fie la o oră fixă în timpul săptămânii (luni-vineri, ex. 10:00, 14:00, etc.).";
            }
        }
    }

}
