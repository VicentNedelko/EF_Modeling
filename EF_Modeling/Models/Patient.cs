﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int? Age { get; set; }
        public DateTime BDate { get; set; }
        public Address Address { get; set; }
        public Area Area { get; set; }
        public List<Visit> Visits { get; set; }

    }
}

