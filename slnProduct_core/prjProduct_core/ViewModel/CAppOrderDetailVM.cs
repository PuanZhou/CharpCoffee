namespace prjProduct_core.ViewModel
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class CAppOrderDetailVM
    {
        [JsonProperty("OrderDetailsId")]
        public int OrderDetailsId { get; set; }

        [JsonProperty("OrderId")]
        public int OrderId { get; set; }

        [JsonProperty("ProductId")]
        public int ProductId { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("Price")]
        public int Price { get; set; }




    }
}
