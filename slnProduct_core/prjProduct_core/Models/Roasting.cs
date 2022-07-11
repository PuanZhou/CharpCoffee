using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Roasting
    {
        public Roasting()
        {
            Coffees = new HashSet<Coffee>();
        }

        public int RoastingId { get; set; }
        public string RoastingName { get; set; }

        public virtual ICollection<Coffee> Coffees { get; set; }
    }
}
