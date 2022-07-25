namespace prjProduct_core.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    public class CAppProductVM
    {
        [JsonProperty("ProductId")]
        public int ProductId { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("Price")]
        public int Price { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Stock")]
        public int Stock { get; set; }

        [JsonProperty("MainPhotoPath")]
        public string MainPhotoPath { get; set; }
    }
}
