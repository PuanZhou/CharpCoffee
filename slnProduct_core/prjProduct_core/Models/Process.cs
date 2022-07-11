using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Process
    {
        public Process()
        {
            Coffees = new HashSet<Coffee>();
        }

        public int ProcessId { get; set; }
        public string ProcessName { get; set; }

        public virtual ICollection<Coffee> Coffees { get; set; }
    }
}
