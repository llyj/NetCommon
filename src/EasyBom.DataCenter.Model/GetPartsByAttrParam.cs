using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class GetPartsByAttrParam
    {
        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        [JsonPropertyName("AttrName")]
        public string AttrName { get; set; }

        [JsonPropertyName("AttrValueKeyword")]
        public string AttrValueKeyword { get; set; }

        [JsonPropertyName("PartLimit")]
        public int? PartLimit { get; set; }

        [JsonPropertyName("PartPdfLimit")]
        public int? PartPdfLimit { get; set; }

    }
}