using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Constellation
    {
        public int ConstellationId { get; set; }
        public string ConstellationName { get; set; }
        public string ConstellationDescription { get; set; }
        public string ConstellationDate { get; set; }
        public int? ConstellationProductId { get; set; }
    }
}
