using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int? Age { get; set; }
        public string Position { get; set; }
        public int? Category { get; set; }
        public DateTime HireDate { get; set; }
        public Area Area { get; set; }
        public Department Department { get; set; }
    }
}
