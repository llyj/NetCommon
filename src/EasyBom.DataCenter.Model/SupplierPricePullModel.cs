using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SupplierPricePullModel
    {
        [JsonPropertyName("LastID")]
        public long? LastID { get; set; }

        [JsonPropertyName("supplierPriceArrays")]
        public List<SupplierPriceArray> SupplierPriceArrays { get; set; }

    }
}