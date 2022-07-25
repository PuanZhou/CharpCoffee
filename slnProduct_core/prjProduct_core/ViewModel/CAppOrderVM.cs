namespace prjProduct_core.ViewModel
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class CAppOrderVM
    {
        [JsonProperty("OrderId")]
        public int OrderId { get; set; }

        [JsonProperty("MemberId")]
        public int MemberId { get; set; }

        [JsonProperty("OrderDate")]
        public DateTime OrderDate { get; set; }

        [JsonProperty("OrderState")]
        public string OrderState { get; set; }

        //[JsonProperty("PaymentId")]
        //public int PaymentId { get; set; }

        //[JsonProperty("PaymentName")]
        //public string PaymentName { get; set; }

        //[JsonProperty("OrderAddress")]
        //public string OrderAddress { get; set; }

        //[JsonProperty("OrderReceiver")]
        //public string OrderReceiver { get; set; }

        //[JsonProperty("OrderPhone")]
        //public string OrderPhone { get; set; }

        //[JsonProperty("CouponId")]
        //public int CouponId { get; set; }

        //[JsonProperty("CouponName")]
        //public string CouponName { get; set; }

        //[JsonProperty("Fee")]
        //public int Fee { get; set; }

        //[JsonProperty("TradeNo")]
        //public string TradeNo { get; set; }
    }
}
