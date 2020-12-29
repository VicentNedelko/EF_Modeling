using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
