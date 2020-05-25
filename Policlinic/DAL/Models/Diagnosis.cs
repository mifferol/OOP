using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   
        public class Diagnosis
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public long DiagnosisId { get; set; }
            public string DiagnosisName { get; set; }
            public string Treatment { get; set; }
    }
    }

