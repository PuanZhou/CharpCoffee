using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Package
    {
        public Package()
        {
            Coffees = new HashSet<Coffee>();
        }

        public int PackageId { get; set; }
        public string PackageName { get; set; }

        public virtual ICollection<Coffee> Coffees { get; set; }
    }
}
