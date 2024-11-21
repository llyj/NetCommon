using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ProductRunDetailParam
    {
        [JsonPropertyName("ProductRunDetails")]
        public List<ProductRunDetail> ProductRunDetails { get; set; }

    }
}