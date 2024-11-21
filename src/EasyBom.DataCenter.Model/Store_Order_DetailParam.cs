using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Store_Order_DetailParam
    {
        [JsonPropertyName("Store_Order_Details")]
        public List<Store_Order_Detail> Store_Order_Details { get; set; }

    }
}