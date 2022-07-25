namespace prjProduct_core.ViewModel
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class CAppCartVM
    {
        [JsonProperty("ShoppingCarDetialsId")]
        public int ShoppingCarDetialsId { get; set; }

        [JsonProperty("MemberId")]
        public int MemberId { get; set; }

        [JsonProperty("ProductsId")]
        public int ProductsId { get; set; }

        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("Price")]
        public int Price { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName  { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("MainPhotoPath")]
        public string MainPhotoPath { get; set; }

        [JsonProperty("Stock")]
        public int Stock { get; set; }
    }
}
