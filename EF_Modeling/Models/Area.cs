using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomNumber { get; set; }
        public Doctor Doctor { get; set; }
    }
}
