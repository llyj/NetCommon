using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Store_Inquiry_DetailParam
    {
        [JsonPropertyName("Store_Inquiry_Details")]
        public List<Store_Inquiry_Detail> Store_Inquiry_Details { get; set; }

    }
}