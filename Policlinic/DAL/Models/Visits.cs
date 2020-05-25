using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   
        public class Visits
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public long VisitId { get; set; }
            public long PatientId { get; set; }
            public long DoctorId { get; set; }
            public long DiagnosisId { get; set; }
            public DateTime Date { get; set; }
        }
    }

