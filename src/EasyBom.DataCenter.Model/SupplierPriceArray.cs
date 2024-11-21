using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SupplierPriceArray
    {
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        [JsonPropertyName("StockNum")]
        public int? StockNum { get; set; }

        [JsonPropertyName("Price")]
        public double? Price { get; set; }

        [JsonPropertyName("Prices")]
        public string Prices { get; set; }

        [JsonPropertyName("Qty")]
        public int? Qty { get; set; }

        [JsonPropertyName("StockNumSource")]
        public string StockNumSource { get; set; }

        [JsonPropertyName("PriceSource")]
        public string PriceSource { get; set; }

        [JsonPropertyName("Currency")]
        public string Currency { get; set; }

        [JsonPropertyName("SupplierID")]
        public int? SupplierID { get; set; }

        [JsonPropertyName("Updatetime")]
        public System.DateTimeOffset? Updatetime { get; set; }

    }
}