using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Prescription Prescription { get; set; }

    }
}
