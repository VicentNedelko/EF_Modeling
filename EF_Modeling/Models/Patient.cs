using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling.Models
{
    public class Patient
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int? Age { get; set; }
        public DateTime BDate { get; set; }
        public Address Address { get; set; }

    }
}

