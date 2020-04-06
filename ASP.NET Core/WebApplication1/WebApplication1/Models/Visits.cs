using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Visits
    {
        public int ID_Visit { get; set; }
        public int ID_Doctor { get; set; }
        public string doc_surname { get; set; }
        public string doc_name { get; set; }
        public int ID_Patient { get; set; }
        public string pat_surname { get; set; }
        public string pat_name { get; set; }
        public int ID_Diag { get; set; }
        public string diag_name { get; set; }
        public int price { get; set; }
        public DateTime? visit_date { get; set; }
    }
}
