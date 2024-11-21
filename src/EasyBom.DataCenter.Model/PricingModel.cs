using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PricingModel
    {
        [JsonPropertyName("Price")]
        public double? Price { get; set; }

        [JsonPropertyName("Qty")]
        public int? Qty { get; set; }

    }
}