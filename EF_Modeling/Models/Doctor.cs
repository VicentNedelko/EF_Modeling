using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling
{
    public class Doctor
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int? Age { get; set; }
        public string Position { get; set; }
        public int? Category { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime RetiredDate { get; set; }

    }
}
