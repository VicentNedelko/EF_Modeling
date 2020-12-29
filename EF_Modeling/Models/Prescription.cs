using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Cure { get; set; }
        public int Period { get; set; }
        public int QuantDay { get; set; }
        public string Comment { get; set; }
        public bool IsActive { get; set; }
        public Visit Visit { get; set; }
    }
}
