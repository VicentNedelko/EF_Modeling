using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNo { get; set; }
        public string Phone { get; set; }
        public Patient Patient { get; set; }

    }
}
