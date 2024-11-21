using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_ParentCategoryParam
    {
        [JsonPropertyName("Page")]
        public int? Page { get; set; }

        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

        [JsonPropertyName("ParentCategoryID")]
        public int ParentCategoryID { get; set; }

        [JsonPropertyName("PartNoIndex")]
        public string PartNoIndex { get; set; }

    }
}