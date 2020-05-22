using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial10.Models
{
    public class Prescription_Medicament
    {
        [Key]
        [ForeignKey("Medicament")]
        public int IdMedicament { get; set; }

        [Key]
        [ForeignKey("Prescription")]
        public int IdPrescription { get; set; }

        public int? Dose { get; set; }
        public string Details { get; set; }

        public virtual Medicament IdMedicamentNavigation { get; set; }
        public virtual Prescription IdPrescriptionNavigation { get; set; }
    }
}
